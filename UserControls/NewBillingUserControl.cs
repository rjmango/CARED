using CARED.Services;
using CARED.Utils;
using CARED.Models;
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
            AddDefaultRow();
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
                if (procedure.Group != lastGroup)
                {
                    lastGroup = procedure.Group;
                    // Add group header
                    displayList.Add(new Procedure
                    {
                        ProcedureID = -1,
                        ProcedureName = $"--- {lastGroup.ToUpper()} ---",
                        Group = lastGroup
                    });
                }
                displayList.Add(procedure);
            }
            return displayList;
        }

        private void AddDefaultRow()
        {
            if (_availableProcedures == null) return;
            var firstRow = new ProcedureListRowUserControl(_availableProcedures);
            firstRow.Dock = DockStyle.Top;
            firstRow.PriceChanged += Row_PriceChanged;
            firstRow.DeleteRequested += Row_DeleteRequested;
            procedureRowsPanel.Controls.Add(firstRow);
            firstRow.BringToFront();
        }


        private void addProcedureButton_Resize(object sender, EventArgs e)
        {
            UIHelper.SetRoundedRegion(addProcedureButton, 15);
        }

        private void addProcedureButton_Click(object sender, EventArgs e)
        {
            var newRow = new ProcedureListRowUserControl(_availableProcedures);
            newRow.Dock = DockStyle.Top;
            newRow.PriceChanged += Row_PriceChanged;
            newRow.DeleteRequested += Row_DeleteRequested;
            procedureRowsPanel.Controls.Add(newRow);
            newRow.BringToFront();
        }

        private void Row_DeleteRequested(object? sender, EventArgs e)
        {
            if (procedureRowsPanel.Controls.Count == 1) return;
            if (sender is ProcedureListRowUserControl row)
            {
                procedureRowsPanel.Controls.Remove(row);
                row.Dispose();
                CalculateGrandTotal();
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
                        if (id > 0)
                        {
                            procedureIds.Add(id);
                        }
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

            // Add back the initial empty row
            AddDefaultRow();
        }

        private void personnelTextbox_Leave(object sender, EventArgs e)
        {
            AppState.CurrentPersonnel = personnelTextbox.Text;
    }
    }
}
