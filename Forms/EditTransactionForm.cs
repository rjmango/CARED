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

        public EditTransactionForm(Transaction transaction)
        {
            InitializeComponent();

            // Populate fields with current data
            // We store the ID to ensure we update the correct record
            UpdatedTransaction = transaction;

            // Store existing procedure IDs so we don't lose them during update
            // (Since this simple form only edits text fields, we preserve the procedures)
            _currentProcedureIds = transaction.TransactedProcedures
                                  .Select(tp => tp.ProcedureID)
                                  .ToList();

            txtCsNo.Text = transaction.CsNo;
            txtName.Text = transaction.Name;
            txtPersonnel.Text = transaction.Personnel;
            txtCompany.Text = transaction.Company;
            txtInsurer.Text = transaction.Insurer;

            // For Date, we'll display it as string for simple editing, 
            // but a DateTimePicker is usually safer. Sticking to "TextBox" per request.
            txtDate.Text = transaction.Date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void InitializeComponent()
        {
            this.txtCsNo = new TextBox();
            this.txtName = new TextBox();
            this.txtPersonnel = new TextBox();
            this.txtCompany = new TextBox();
            this.txtInsurer = new TextBox();
            this.txtDate = new TextBox();
            this.btnEdit = new Button();
            this.btnCancel = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.SuspendLayout();

            // Layout helper variables
            int startX = 30;
            int startY = 30;
            int gap = 50;

            // Labels and TextBoxes
            SetupField(label1, "CS No:", txtCsNo, startX, startY);
            SetupField(label2, "Date:", txtDate, startX, startY + gap);
            SetupField(label3, "Name:", txtName, startX, startY + gap * 2);
            SetupField(label4, "Personnel:", txtPersonnel, startX, startY + gap * 3);
            SetupField(label5, "Company:", txtCompany, startX, startY + gap * 4);
            SetupField(label6, "Insurer:", txtInsurer, startX, startY + gap * 5);

            // Buttons
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(startX, startY + gap * 7);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            //this.btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(startX + 120, startY + gap * 7);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Click += btnEdit_Click;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCsNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPersonnel);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtInsurer);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Update the object with new values
            UpdatedTransaction.CsNo = txtCsNo.Text;
            UpdatedTransaction.Name = txtName.Text;
            UpdatedTransaction.Personnel = txtPersonnel.Text;
            UpdatedTransaction.Company = txtCompany.Text;
            UpdatedTransaction.Insurer = txtInsurer.Text;

            if (DateTime.TryParse(txtDate.Text, out DateTime parsedDate))
            {
                UpdatedTransaction.Date = parsedDate;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Getter for the preserved procedure IDs
        public List<int> GetProcedureIds() => _currentProcedureIds;

        private TextBox txtCsNo;
        private TextBox txtName;
        private TextBox txtPersonnel;
        private TextBox txtCompany;
        private TextBox txtInsurer;
        private TextBox txtDate;
        private Button btnEdit;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}