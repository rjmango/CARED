using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CARED.Models;

namespace CARED.Forms
{
    public partial class EditTransactionForm : Form
    {
        public Transaction UpdatedTransaction { get; private set; }
        private List<int> _currentProcedureIds;

        private List<Procedure> _displayProcedures;
        private List<Procedure> _allAvailableProcedures;

        public EditTransactionForm(Transaction transaction, List<Procedure> allProcedures)
        {
            InitializeComponent();

            // Populate fields with current data
            // We store the ID to ensure we update the correct record
            UpdatedTransaction = transaction;
            _allAvailableProcedures = allProcedures;

            // 1. Setup the Internal Lists
            // Extract the actual Procedure objects from the transaction for display
            _displayProcedures = transaction.TransactedProcedures
                                  .Select(tp => tp.Procedure)
                                  .Where(p => p != null) // Safety check
                                  .ToList();

            // Initialize the ID list based on the above
            _currentProcedureIds = _displayProcedures.Select(p => p.ProcedureID).ToList();

            // 2. Setup the "Current Procedures" ListBox
            lstProcedures.DataSource = null; // Reset
            lstProcedures.DataSource = _displayProcedures;
            lstProcedures.DisplayMember = "ProcedureName";
            lstProcedures.ValueMember = "ProcedureID";

            // 3. Setup the "Add New Procedure" ComboBox
            cmbAllProcedures.DataSource = _allAvailableProcedures;
            cmbAllProcedures.DisplayMember = "ProcedureName";
            cmbAllProcedures.ValueMember = "ProcedureID";

            // 4. Populate Text Fields
            txtCsNo.Text = transaction.CsNo;
            txtName.Text = transaction.Name;
            txtPersonnel.Text = transaction.Personnel;
            txtCompany.Text = transaction.Company;
            txtInsurer.Text = transaction.Insurer;

            // --- NEW: Set DateTimePicker Value ---
            dtpDate.Value = transaction.Date;
        }

        private void InitializeComponent()
        {
            this.txtCsNo = new TextBox();
            this.txtName = new TextBox();
            this.txtPersonnel = new TextBox();
            this.txtCompany = new TextBox();
            this.txtInsurer = new TextBox();
            // DateTimePicker
            this.dtpDate = new DateTimePicker();
            this.btnEdit = new Button();
            this.btnCancel = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();

            // NEW CONTROLS
            this.lstProcedures = new ListBox();
            this.cmbAllProcedures = new ComboBox();
            this.btnAddProcedure = new Button();
            this.btnRemoveProcedure = new Button();
            this.lblProcedures = new Label();

            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.White;

            // Layout helper variables
            int startX = 30;
            int startY = 30;
            int gap = 50;

            // Labels and TextBoxes
            SetupField(label1, "CS No:", txtCsNo, startX, startY);
            // --- NEW: Setup Date Picker Manually ---
            // Label
            label2.Text = "Date:";
            label2.Location = new System.Drawing.Point(startX, startY + gap);
            label2.AutoSize = true;
            // Picker
            dtpDate.Location = new System.Drawing.Point(startX + 100, startY + gap - 3);
            dtpDate.Size = new System.Drawing.Size(200, 25);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy-MM-dd"; // Shows Date Only
            SetupField(label3, "Name:", txtName, startX, startY + gap * 2);
            SetupField(label4, "Personnel:", txtPersonnel, startX, startY + gap * 3);
            SetupField(label5, "Company:", txtCompany, startX, startY + gap * 4);
            SetupField(label6, "Insurer:", txtInsurer, startX, startY + gap * 5);

            // --- RIGHT SIDE: PROCEDURES MANAGER ---
            int rightSideX = 350; // Start the right section

            // Label
            this.lblProcedures.Text = "Laboratory Request/s:";
            this.lblProcedures.Location = new System.Drawing.Point(rightSideX, startY);
            this.lblProcedures.AutoSize = true;
            this.lblProcedures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // ListBox (Shows current items)
            this.lstProcedures.Location = new System.Drawing.Point(rightSideX, startY + 25);
            this.lstProcedures.Size = new System.Drawing.Size(280, 200);

            // Remove Button
            this.btnRemoveProcedure.Text = "Remove Selected";
            this.btnRemoveProcedure.Location = new System.Drawing.Point(rightSideX, startY + 230);
            this.btnRemoveProcedure.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveProcedure.Click += btnRemoveProcedure_Click;

            // ComboBox (Select to Add)
            this.cmbAllProcedures.Location = new System.Drawing.Point(rightSideX, startY + 280);
            this.cmbAllProcedures.Size = new System.Drawing.Size(190, 25);
            this.cmbAllProcedures.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add Button
            this.btnAddProcedure.Text = "Add";
            this.btnAddProcedure.Location = new System.Drawing.Point(rightSideX + 200, startY + 280);
            this.btnAddProcedure.Size = new System.Drawing.Size(80, 27);
            this.btnAddProcedure.Click += btnAddProcedure_Click;

            // Buttons
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(startX, startY + gap * 7);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(startX + 120, startY + gap * 7);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Click += btnEdit_Click;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);

            // Add Fields
            this.Controls.Add(this.txtCsNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPersonnel);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtInsurer);
            this.Controls.Add(this.dtpDate);

            // Add Labels
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);

            // Add Procedure Controls
            this.Controls.Add(this.lblProcedures);
            this.Controls.Add(this.lstProcedures);
            this.Controls.Add(this.cmbAllProcedures);
            this.Controls.Add(this.btnAddProcedure);
            this.Controls.Add(this.btnRemoveProcedure);

            this.Text = "Edit Transaction";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void SetupField(Label lbl, string lblText, TextBox txt, int x, int y)
        {
            lbl.Text = lblText;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;

            txt.Location = new System.Drawing.Point(x + 100, y - 3);
            txt.Size = new System.Drawing.Size(200, 25);
        }

        // --- EVENT HANDLERS ---

        private void btnAddProcedure_Click(object sender, EventArgs e)
        {
            var selectedProc = cmbAllProcedures.SelectedItem as Procedure;
            if (selectedProc == null) return;

            // Prevent adding duplicates
            if (_displayProcedures.Any(p => p.ProcedureID == selectedProc.ProcedureID))
            {
                MessageBox.Show("This procedure is already in the list.");
                return;
            }

            // Add to display list
            _displayProcedures.Add(selectedProc);

            // Refresh UI
            RefreshProcedureList();
        }

        private void btnRemoveProcedure_Click(object sender, EventArgs e)
        {
            var selectedProc = lstProcedures.SelectedItem as Procedure;
            if (selectedProc == null) return;

            // Remove from display list
            _displayProcedures.Remove(selectedProc);

            // Refresh UI
            RefreshProcedureList();
        }

        private void RefreshProcedureList()
        {
            // Simple re-binding to refresh ListBox
            lstProcedures.DataSource = null;
            lstProcedures.DataSource = _displayProcedures;
            lstProcedures.DisplayMember = "ProcedureName";
            lstProcedures.ValueMember = "ProcedureID";

            // Update the ID list that will be sent back to database
            _currentProcedureIds = _displayProcedures.Select(p => p.ProcedureID).ToList();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Update the object with new values
            UpdatedTransaction.CsNo = txtCsNo.Text;
            UpdatedTransaction.Name = txtName.Text;
            UpdatedTransaction.Personnel = txtPersonnel.Text;
            UpdatedTransaction.Company = txtCompany.Text;
            UpdatedTransaction.Insurer = txtInsurer.Text;
            UpdatedTransaction.Date = dtpDate.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Getter for the preserved procedure IDs
        public List<int> GetProcedureIds() => _currentProcedureIds;

        private TextBox txtCsNo = null!;
        private TextBox txtName = null!;
        private TextBox txtPersonnel = null!;
        private TextBox txtCompany = null!;
        private TextBox txtInsurer = null!;
        private DateTimePicker dtpDate = null!;
        private Button btnEdit = null!;
        private Button btnCancel = null!;
        private Label label1 = null!;
        private Label label2 = null!;
        private Label label3 = null!;
        private Label label4 = null!;
        private Label label5 = null!;
        private Label label6 = null!;

        // New UI Controls
        private ListBox lstProcedures = null!;
        private ComboBox cmbAllProcedures = null!;
        private Button btnAddProcedure = null!;
        private Button btnRemoveProcedure = null!;
        private Label lblProcedures = null!;
    }
}