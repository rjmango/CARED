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
            exportButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            ChargeSlipCheckBox = new CheckBox();
            BillingStatementCheckBox = new CheckBox();
            bsPopup = new TableLayoutPanel();
            hmoLabel = new Label();
            bsNameTitle = new TextBox();
            hmoTitle = new TextBox();
            bsNameLabel = new Label();
            border = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            bsPopup.SuspendLayout();
            border.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 2);
            tableLayoutPanel1.Controls.Add(exportButton, 2, 4);
            tableLayoutPanel1.Controls.Add(panel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(798, 598);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(filenameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(fileNameTextBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(162, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(153, 113);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // filenameLabel
            // 
            filenameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(3, 41);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(63, 15);
            filenameLabel.TabIndex = 17;
            filenameLabel.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameTextBox.Location = new Point(3, 59);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(147, 23);
            fileNameTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(monthLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(162, 241);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(153, 113);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May ", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(3, 59);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(147, 23);
            monthComboBox.TabIndex = 6;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // monthLabel
            // 
            monthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(3, 41);
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
            tableLayoutPanel3.Location = new Point(162, 122);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(153, 113);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // insurerComboBox
            // 
            insurerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            insurerComboBox.FormattingEnabled = true;
            insurerComboBox.Items.AddRange(new object[] { "Intellicare" });
            insurerComboBox.Location = new Point(3, 59);
            insurerComboBox.Name = "insurerComboBox";
            insurerComboBox.Size = new Size(147, 23);
            insurerComboBox.TabIndex = 18;
            // 
            // insurerLabel
            // 
            insurerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            insurerLabel.AutoSize = true;
            insurerLabel.Location = new Point(3, 41);
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
            tableLayoutPanel5.Location = new Point(480, 241);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(153, 113);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(3, 41);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 17;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            yearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yearTextBox.Location = new Point(3, 59);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(147, 23);
            yearTextBox.TabIndex = 7;
            yearTextBox.TextChanged += yearTextBox_TextChanged;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exportButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.Location = new Point(321, 479);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(153, 56);
            exportButton.TabIndex = 10;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(36, 48, 34);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Location = new Point(162, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 113);
            panel1.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.Silver;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(ChargeSlipCheckBox, 0, 0);
            tableLayoutPanel6.Controls.Add(BillingStatementCheckBox, 1, 0);
            tableLayoutPanel6.Controls.Add(bsPopup, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(471, 113);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // ChargeSlipCheckBox
            // 
            ChargeSlipCheckBox.Anchor = AnchorStyles.Left;
            ChargeSlipCheckBox.AutoSize = true;
            ChargeSlipCheckBox.Location = new Point(3, 18);
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
            BillingStatementCheckBox.Location = new Point(238, 18);
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
            bsPopup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.27273F));
            bsPopup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.72727F));
            bsPopup.Controls.Add(hmoLabel, 0, 1);
            bsPopup.Controls.Add(bsNameTitle, 1, 0);
            bsPopup.Controls.Add(hmoTitle, 1, 1);
            bsPopup.Controls.Add(bsNameLabel, 0, 0);
            bsPopup.Dock = DockStyle.Fill;
            bsPopup.Location = new Point(238, 59);
            bsPopup.Name = "bsPopup";
            bsPopup.RowCount = 2;
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.Size = new Size(230, 51);
            bsPopup.TabIndex = 17;
            bsPopup.Visible = false;
            bsPopup.Paint += bsPopup_Paint;
            // 
            // hmoLabel
            // 
            hmoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hmoLabel.AutoSize = true;
            hmoLabel.Location = new Point(20, 25);
            hmoLabel.Name = "hmoLabel";
            hmoLabel.Size = new Size(39, 15);
            hmoLabel.TabIndex = 3;
            hmoLabel.Text = "HMO:";
            // 
            // bsNameTitle
            // 
            bsNameTitle.Dock = DockStyle.Fill;
            bsNameTitle.Location = new Point(65, 3);
            bsNameTitle.Name = "bsNameTitle";
            bsNameTitle.Size = new Size(162, 23);
            bsNameTitle.TabIndex = 0;
            bsNameTitle.TextChanged += bsNameTitle_TextChanged;
            // 
            // hmoTitle
            // 
            hmoTitle.Dock = DockStyle.Fill;
            hmoTitle.Location = new Point(65, 28);
            hmoTitle.Name = "hmoTitle";
            hmoTitle.Size = new Size(162, 23);
            hmoTitle.TabIndex = 1;
            hmoTitle.TextChanged += hmoTitle_TextChanged;
            // 
            // bsNameLabel
            // 
            bsNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bsNameLabel.AutoSize = true;
            bsNameLabel.Location = new Point(26, 0);
            bsNameLabel.Name = "bsNameLabel";
            bsNameLabel.Size = new Size(33, 15);
            bsNameLabel.TabIndex = 2;
            bsNameLabel.Text = "Title:";
            bsNameLabel.Click += label1_Click;
            // 
            // border
            // 
            border.BackColor = SystemColors.ActiveCaptionText;
            border.Controls.Add(tableLayoutPanel1);
            border.Dock = DockStyle.Fill;
            border.Location = new Point(0, 0);
            border.Name = "border";
            border.Padding = new Padding(1);
            border.Size = new Size(800, 600);
            border.TabIndex = 17;
            // 
            // ExportRecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(border);
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
            border.ResumeLayout(false);
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
        private Panel border;
        private TableLayoutPanel bsPopup;
        private Label hmoLabel;
        private TextBox bsNameTitle;
        private TextBox hmoTitle;
        private Label bsNameLabel;
    }
}
