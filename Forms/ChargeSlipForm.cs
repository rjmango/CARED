using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CARED.Models;

namespace CARED.Forms
{
    public class ChargeSlipForm : Form
    {
        public ChargeSlipForm(Transaction t)
        {
            InitializeComponent();
            PopulateData(t);
        }

        private void PopulateData(Transaction t)
        {
            // Header Info
            lblCsNo.Text = $"CS #: {t.CsNo}";
            lblDate.Text = $"Date: {t.Date:MMM dd, yyyy}";
            lblName.Text = $"Name: {t.Name}";
            lblInfo.Text = $"Company: {t.Company}\nInsurer: {t.Insurer}\nPhysician: {t.Personnel}";

            // Procedures List & Calculation
            decimal grandTotal = 0;
            lstProcedures.Items.Clear();

            if (t.TransactedProcedures != null)
            {
                foreach (var tp in t.TransactedProcedures)
                {
                    if (tp.Procedure != null)
                    {
                        // Add line: "Procedure Name ............ 500.00"
                        string name = tp.Procedure.ProcedureName;
                        if (name.Length > 20) name = name.Substring(0, 17) + "..."; // Truncate long names

                        decimal price = tp.Procedure.Amount;
                        grandTotal += price;

                        // Format: Name padded right, Price padded left
                        string lineItem = $"{name.PadRight(25)} {price.ToString("N2").PadLeft(10)}";
                        lstProcedures.Items.Add(lineItem);
                    }
                }
            }

            lblTotal.Text = $"TOTAL: {grandTotal:N2}";
        }

        // --- UI DEFINITION ---
        private Label lblHeader;
        private Label lblSeparator1;
        private Label lblCsNo;
        private Label lblDate;
        private Label lblName;
        private Label lblInfo;
        private Label lblSeparator2;
        private ListBox lstProcedures;
        private Label lblSeparator3;
        private Label lblTotal;
        private Button btnClose;

        private void InitializeComponent()
        {
            this.lblHeader = new Label();
            this.lblSeparator1 = new Label();
            this.lblCsNo = new Label();
            this.lblDate = new Label();
            this.lblName = new Label();
            this.lblInfo = new Label();
            this.lblSeparator2 = new Label();
            this.lstProcedures = new ListBox();
            this.lblSeparator3 = new Label();
            this.lblTotal = new Label();
            this.btnClose = new Button();
            this.SuspendLayout();

            // Font Settings (Monospaced for receipt look)
            Font receiptFont = new Font("Consolas", 10F, FontStyle.Regular);
            Font headerFont = new Font("Consolas", 14F, FontStyle.Bold);

            // 1. Header
            lblHeader.Text = "OFFICIAL CHARGE SLIP";
            lblHeader.Font = headerFont;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Location = new Point(10, 10);
            lblHeader.Size = new Size(360, 30);

            // 2. Separator
            lblSeparator1.Text = "---------------------------------------";
            lblSeparator1.Font = receiptFont;
            lblSeparator1.Location = new Point(10, 40);
            lblSeparator1.AutoSize = true;

            // 3. Basic Details
            lblCsNo.Location = new Point(20, 60);
            lblCsNo.AutoSize = true;
            lblCsNo.Font = receiptFont;

            lblDate.Location = new Point(200, 60);
            lblDate.AutoSize = true;
            lblDate.Font = receiptFont;

            lblName.Location = new Point(20, 85);
            lblName.AutoSize = true;
            lblName.Font = receiptFont;

            // 4. Extra Info (Multi-line)
            lblInfo.Location = new Point(20, 110);
            lblInfo.Size = new Size(340, 60);
            lblInfo.Font = receiptFont;

            // 5. Separator
            lblSeparator2.Text = "---------------------------------------";
            lblSeparator2.Font = receiptFont;
            lblSeparator2.Location = new Point(10, 170);
            lblSeparator2.AutoSize = true;

            // 6. Procedures List
            lstProcedures.Location = new Point(20, 195);
            lstProcedures.Size = new Size(340, 150);
            lstProcedures.Font = receiptFont;
            lstProcedures.BorderStyle = BorderStyle.None;
            lstProcedures.BackColor = Color.White;

            // 7. Total Section
            lblSeparator3.Text = "---------------------------------------";
            lblSeparator3.Font = receiptFont;
            lblSeparator3.Location = new Point(10, 350);
            lblSeparator3.AutoSize = true;

            lblTotal.Text = "TOTAL: 0.00";
            lblTotal.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(20, 370);
            lblTotal.Size = new Size(340, 30);

            // 8. Close Button
            btnClose.Text = "Close";
            btnClose.Location = new Point(140, 420);
            btnClose.Size = new Size(100, 35);
            btnClose.Click += (s, e) => this.Close();

            // Form Properties
            this.ClientSize = new Size(380, 470);
            this.Controls.Add(lblHeader);
            this.Controls.Add(lblSeparator1);
            this.Controls.Add(lblCsNo);
            this.Controls.Add(lblDate);
            this.Controls.Add(lblName);
            this.Controls.Add(lblInfo);
            this.Controls.Add(lblSeparator2);
            this.Controls.Add(lstProcedures);
            this.Controls.Add(lblSeparator3);
            this.Controls.Add(lblTotal);
            this.Controls.Add(btnClose);

            this.Text = "Detailed View";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.BackColor = Color.White;
            this.MaximizeBox = false;
        }
    }
}