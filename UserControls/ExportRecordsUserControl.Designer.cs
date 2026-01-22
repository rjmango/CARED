namespace CARED.UserControls
{
    partial class ExportRecordsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            filenameLabel = new Label();
            fileNameTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            monthComboBox = new ComboBox();
            monthLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            insurerComboBox = new ComboBox();
            insurerLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            ChargeSlipCheckBox = new CheckBox();
            BillingStatementCheckBox = new CheckBox();
            bsPopup = new TableLayoutPanel();
            hmoLabel = new Label();
            bsNameTitle = new TextBox();
            hmoTitle = new TextBox();
            bsNameLabel = new Label();
            csSuggestion = new Label();
            exportButton = new Button();
            panel2 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            bsPopup.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0001278F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9998741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99999356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9998741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0001278F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 3);
            tableLayoutPanel1.Controls.Add(exportButton, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(794, 549);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(filenameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(fileNameTextBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(82, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(303, 103);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // filenameLabel
            // 
            filenameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            filenameLabel.AutoSize = true;
            filenameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filenameLabel.Location = new Point(3, 36);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(63, 15);
            filenameLabel.TabIndex = 17;
            filenameLabel.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameTextBox.BackColor = Color.FromArgb(240, 237, 226);
            fileNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileNameTextBox.Location = new Point(3, 54);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(297, 29);
            fileNameTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(monthLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(82, 221);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(303, 103);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthComboBox.BackColor = Color.FromArgb(240, 237, 226);
            monthComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May ", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(3, 54);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(297, 29);
            monthComboBox.TabIndex = 6;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // monthLabel
            // 
            monthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthLabel.Location = new Point(3, 36);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(46, 15);
            monthLabel.TabIndex = 16;
            monthLabel.Text = "Month:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(insurerComboBox, 0, 1);
            tableLayoutPanel3.Controls.Add(insurerLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(82, 112);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(303, 103);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // insurerComboBox
            // 
            insurerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            insurerComboBox.BackColor = Color.FromArgb(240, 237, 226);
            insurerComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insurerComboBox.FormattingEnabled = true;
            insurerComboBox.Items.AddRange(new object[] { "Intellicare" });
            insurerComboBox.Location = new Point(3, 54);
            insurerComboBox.Name = "insurerComboBox";
            insurerComboBox.Size = new Size(297, 29);
            insurerComboBox.TabIndex = 18;
            // 
            // insurerLabel
            // 
            insurerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            insurerLabel.AutoSize = true;
            insurerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            insurerLabel.Location = new Point(3, 36);
            insurerLabel.Name = "insurerLabel";
            insurerLabel.Size = new Size(46, 15);
            insurerLabel.TabIndex = 17;
            insurerLabel.Text = "Insurer:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(yearLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(yearTextBox, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(406, 221);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(303, 103);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            yearLabel.Location = new Point(3, 36);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 17;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            yearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yearTextBox.BackColor = Color.FromArgb(240, 237, 226);
            yearTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yearTextBox.Location = new Point(3, 54);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(297, 29);
            yearTextBox.TabIndex = 7;
            yearTextBox.TextChanged += yearTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 237, 226);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(82, 330);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(627, 103);
            panel1.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(240, 237, 227);
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(ChargeSlipCheckBox, 0, 0);
            tableLayoutPanel6.Controls.Add(BillingStatementCheckBox, 1, 0);
            tableLayoutPanel6.Controls.Add(bsPopup, 1, 1);
            tableLayoutPanel6.Controls.Add(csSuggestion, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.ForeColor = SystemColors.ControlText;
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(615, 91);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // ChargeSlipCheckBox
            // 
            ChargeSlipCheckBox.Anchor = AnchorStyles.Left;
            ChargeSlipCheckBox.AutoSize = true;
            ChargeSlipCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChargeSlipCheckBox.Location = new Point(3, 13);
            ChargeSlipCheckBox.Name = "ChargeSlipCheckBox";
            ChargeSlipCheckBox.Size = new Size(86, 19);
            ChargeSlipCheckBox.TabIndex = 0;
            ChargeSlipCheckBox.Text = "Charge Slip";
            ChargeSlipCheckBox.UseVisualStyleBackColor = true;
            ChargeSlipCheckBox.CheckedChanged += ChargeSlipCheckBox_CheckedChanged;
            // 
            // BillingStatementCheckBox
            // 
            BillingStatementCheckBox.Anchor = AnchorStyles.Left;
            BillingStatementCheckBox.AutoSize = true;
            BillingStatementCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BillingStatementCheckBox.Location = new Point(310, 13);
            BillingStatementCheckBox.Name = "BillingStatementCheckBox";
            BillingStatementCheckBox.Size = new Size(116, 19);
            BillingStatementCheckBox.TabIndex = 1;
            BillingStatementCheckBox.Text = "Billing Statement";
            BillingStatementCheckBox.UseVisualStyleBackColor = true;
            BillingStatementCheckBox.CheckedChanged += BillingStatementCheckBox_CheckedChanged;
            // 
            // bsPopup
            // 
            bsPopup.ColumnCount = 2;
            bsPopup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            bsPopup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            bsPopup.Controls.Add(hmoLabel, 0, 1);
            bsPopup.Controls.Add(bsNameTitle, 1, 0);
            bsPopup.Controls.Add(hmoTitle, 1, 1);
            bsPopup.Controls.Add(bsNameLabel, 0, 0);
            bsPopup.Dock = DockStyle.Fill;
            bsPopup.Location = new Point(310, 48);
            bsPopup.Name = "bsPopup";
            bsPopup.RowCount = 2;
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.Size = new Size(302, 40);
            bsPopup.TabIndex = 17;
            bsPopup.Visible = false;
            bsPopup.Paint += bsPopup_Paint;
            // 
            // hmoLabel
            // 
            hmoLabel.Anchor = AnchorStyles.Right;
            hmoLabel.AutoSize = true;
            hmoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hmoLabel.Location = new Point(6, 22);
            hmoLabel.Margin = new Padding(0);
            hmoLabel.Name = "hmoLabel";
            hmoLabel.Size = new Size(39, 15);
            hmoLabel.TabIndex = 3;
            hmoLabel.Text = "HMO:";
            // 
            // bsNameTitle
            // 
            bsNameTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bsNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bsNameTitle.Location = new Point(48, 3);
            bsNameTitle.Name = "bsNameTitle";
            bsNameTitle.Size = new Size(251, 29);
            bsNameTitle.TabIndex = 0;
            bsNameTitle.TextChanged += bsNameTitle_TextChanged;
            // 
            // hmoTitle
            // 
            hmoTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hmoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hmoTitle.Location = new Point(48, 23);
            hmoTitle.Name = "hmoTitle";
            hmoTitle.Size = new Size(251, 29);
            hmoTitle.TabIndex = 1;
            hmoTitle.TextChanged += hmoTitle_TextChanged;
            // 
            // bsNameLabel
            // 
            bsNameLabel.Anchor = AnchorStyles.Right;
            bsNameLabel.AutoSize = true;
            bsNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bsNameLabel.Location = new Point(12, 2);
            bsNameLabel.Margin = new Padding(0);
            bsNameLabel.Name = "bsNameLabel";
            bsNameLabel.Size = new Size(33, 15);
            bsNameLabel.TabIndex = 2;
            bsNameLabel.Text = "Title:";
            bsNameLabel.Click += label1_Click;
            // 
            // csSuggestion
            // 
            csSuggestion.AutoSize = true;
            csSuggestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csSuggestion.Location = new Point(3, 45);
            csSuggestion.Name = "csSuggestion";
            csSuggestion.Size = new Size(301, 42);
            csSuggestion.TabIndex = 18;
            csSuggestion.Text = "Suggestion for printing: A4, Portrait, Fit All Columns on One Page";
            csSuggestion.Visible = false;
            csSuggestion.Click += label1_Click_1;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.None;
            exportButton.BackColor = Color.FromArgb(149, 176, 115);
            tableLayoutPanel1.SetColumnSpan(exportButton, 3);
            exportButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.Location = new Point(220, 464);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(350, 56);
            exportButton.TabIndex = 10;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 600);
            panel2.TabIndex = 17;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(240, 237, 226);
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 92.5F));
            tableLayoutPanel7.Size = new Size(800, 600);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(36, 49, 34);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 45);
            label1.TabIndex = 3;
            label1.Text = "Export Template";
            // 
            // ExportRecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "ExportRecordsUserControl";
            Size = new Size(800, 600);
            Load += DashboardUserControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            bsPopup.ResumeLayout(false);
            bsPopup.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label filenameLabel;
        private TextBox fileNameTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox monthComboBox;
        private Label monthLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox insurerComboBox;
        private Label insurerLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label yearLabel;
        private TextBox yearTextBox;
        private Button exportButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox ChargeSlipCheckBox;
        private CheckBox BillingStatementCheckBox;
        private TableLayoutPanel bsPopup;
        private Label hmoLabel;
        private TextBox bsNameTitle;
        private TextBox hmoTitle;
        private Label bsNameLabel;
        private Label csSuggestion;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
    }
}
