using CARED.Forms;
using CARED.Models;
using CARED.Services;
using CARED.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARED.UserControls
{
    public partial class NewBillingUserControl : UserControl
    {
        private readonly IProcedureService _procedureService;
        private readonly ITransactionService _transactionService;
        private List<Procedure>? _availableProcedures;
        public NewBillingUserControl(IProcedureService procedureService, ITransactionService transactionService)
        {
            _procedureService = procedureService;
            _transactionService = transactionService;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            UIHelper.SetRoundedRegion(ctrl, 5);
        }

        private async void NewBillingUserControl_Load(object sender, EventArgs e)
        {
            _availableProcedures = await _procedureService.GetAllProceduresAsync();
            _availableProcedures = CreateGroupedList(_availableProcedures);
            personnelTextbox.Text = AppState.CurrentPersonnel;
            //addProcedureDisabledTooltip.SetToolTip(addProcedureButton, "Please select a procedure in the current row before adding a new one.");
            //addProcedureButton.BackColor = Color.Gray;
            //AddDefaultRow();
        }

        // this function creates the list of procedures with header for the dropdown visuals)
        private List<Procedure> CreateGroupedList(List<Procedure> dbProcedures)
        {
            var displayList = new List<Procedure>();
            var sortedProcedures = dbProcedures
                .OrderBy(p => p.Group)
                .ThenBy(p => p.ProcedureName);
            string lastGroup = "";

            foreach (var procedure in sortedProcedures)
            {
                displayList.Add(procedure);
            }
            return displayList;
        }

        private void addProcedureButton_Resize(object sender, EventArgs e)
        {
            UIHelper.SetRoundedRegion(addProcedureButton, 15);
        }

        private void addProcedureButton_Click(object sender, EventArgs e)
        {
            var currentRows = procedureRowsPanel.Controls.OfType<ProcedureListRowUserControl>().ToList();
            var currentProceduresSelected = new HashSet<string>(currentRows.Select(r => r.SelectedProcedureName));

            using (var popup = new ProcedureSelectionForm(_availableProcedures, currentProceduresSelected))
            {
                if (popup.ShowDialog() != DialogResult.OK) return;
                
                if (popup.SelectedProcedures.Count == 0)
                { 
                    procedureSelectionPlaceholder.Visible = true;
                }
                else
                {
                    procedureSelectionPlaceholder.Visible = false;
                }
                    
                var checkedNames = new HashSet<string>(popup.SelectedProcedures.Select(p => p.ProcedureName));

                foreach (var row in currentRows)
                {
                    if (!checkedNames.Contains(row.SelectedProcedureName))
                    {
                        procedureRowsPanel.Controls.Remove(row);
                        row.Dispose(); // Mandatory for cleaning up event handlers
                    }
                }

                foreach (var proc in popup.SelectedProcedures)
                {
                    if (!currentProceduresSelected.Contains(proc.ProcedureName))
                    {
                        AddNewProcedureRow(proc);
                    }
                }
                CalculateGrandTotal();
            }
        }

        private void AddNewProcedureRow(Procedure? procedure)
        {
            var bottomRow = GetBottomMostRow();
            //if (bottomRow != null && !bottomRow.IsSelectionValid) return;

            var newRow = new ProcedureListRowUserControl(procedure);
            newRow.Margin = new Padding(0);
            newRow.Dock = DockStyle.Top;
            newRow.PriceChanged += Row_PriceChanged;
            newRow.DeleteRequested += Row_DeleteRequested;

            procedureRowsPanel.Controls.Add(newRow);
            newRow.BringToFront();
            procedureRowsPanel.ScrollControlIntoView(newRow);
            CalculateGrandTotal();
        }

        private void Row_DeleteRequested(object? sender, EventArgs e)
        {
            if (sender is ProcedureListRowUserControl row)
            {
                procedureRowsPanel.Controls.Remove(row);
                row.Dispose();
                CalculateGrandTotal();
            }

            if (procedureRowsPanel.Controls.Count == 1)
            {
                procedureSelectionPlaceholder.Visible = true;
            }
        }

        private void Row_PriceChanged(object? sender, EventArgs e)
        {
            CalculateGrandTotal();
        }

        private void CalculateGrandTotal()
        {
            decimal total = 0;
            foreach (Control ctrl in procedureRowsPanel.Controls)
            {
                if (ctrl is ProcedureListRowUserControl row)
                    total += row.GetLineTotal();
            }

            totalAmount.Text = total.ToString("C2");
        }

        private void procedureRowsPanel_Resize(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            UIHelper.SetRoundedBottomOnly(ctrl, 15);
        }

        private void procedureListLabelLayout_Resize(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            UIHelper.SetRoundedTopOnly(ctrl, 15);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsFormValid()) return;

                var procedureIds = new List<int>();
                foreach (Control ctrl in procedureRowsPanel.Controls)
                {
                    if (ctrl is ProcedureListRowUserControl row)
                    {
                        int id = row.GetSelectedProcedureID();
                        procedureIds.Add(id);
                    }
                }

                if (!procedureIds.Any())
                {
                    MessageBox.Show("Please select at least one valid procedure.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newTransaction = new Transaction
                {
                    Insurer = "Intellicare",
                    CsNo = csNoTextbox.Text.Trim(),
                    Date = dateTimePicker1.Value,
                    Name = patientNameTextbox.Text.Trim(),
                    Personnel = personnelTextbox.Text.Trim(),
                    Company = companyTextbox.Text.Trim()
                };

                saveButton.Enabled = false;
                await _transactionService.AddTransaction(newTransaction, procedureIds);
                MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                saveButton.Enabled = true;
            }
        }
        private bool IsFormValid()
        {
            if (!IsValid(patientNameTextbox, "Patient Name")) return false;
            if (!IsValid(csNoTextbox, "Customer Number")) return false;
            if (!IsValid(personnelTextbox, "Personnel In Charge")) return false;
            if (!IsValid(companyTextbox, "Company")) return false;

            foreach (Control ctr in procedureRowsPanel.Controls)
            {
                if (ctr is ProcedureListRowUserControl row)
                {
                    if (row.GetSelectedProcedureID() <= 0)
                    {
                        MessageBox.Show("Please select a valid procedure in all rows.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ctr.Focus();
                        return false;
                    }
                }
            }


            return true; // All checks passed
        }

        private bool IsValid(TextBox tb, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"{fieldName} is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
        private void ClearForm()
        {
            // Clear all TextBoxes in the UserControl
            patientNameTextbox.Clear();
            csNoTextbox.Clear();
            companyTextbox.Clear();

            // Reset your specific UI elements
            dateTimePicker1.Value = DateTime.Now;
            procedureRowsPanel.Controls.Clear();
            totalAmount.Text = 0.ToString("C2");

        }

        private void personnelTextbox_Leave(object sender, EventArgs e)
        {
            AppState.CurrentPersonnel = personnelTextbox.Text;
        }

        private ProcedureListRowUserControl GetBottomMostRow()
        {
            return procedureRowsPanel.Controls.OfType<ProcedureListRowUserControl>()
                    .OrderByDescending(row => row.Bottom)
                    .FirstOrDefault();
        }

        
    }
}
