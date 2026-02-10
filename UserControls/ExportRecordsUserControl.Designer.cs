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
            tableLayoutPanel12 = new TableLayoutPanel();
            label6 = new Label();
            panel10 = new Panel();
            textBox6 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            monthComboBox = new ComboBox();
            monthLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel3 = new Panel();
            yearTextBox = new TextBox();
            yearLabel = new Label();
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
            Header = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            bsPopup.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.00013F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9998741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99999356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9998741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0001278F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(exportButton, 1, 3);
            tableLayoutPanel1.Location = new Point(0, 59);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 555);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label6, 0, 0);
            tableLayoutPanel12.Controls.Add(panel10, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(83, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(305, 132);
            tableLayoutPanel12.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 36);
            label6.Name = "label6";
            label6.Size = new Size(115, 30);
            label6.TabIndex = 17;
            label6.Text = "File Name:";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.FromArgb(240, 237, 226);
            panel10.Controls.Add(textBox6);
            panel10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.ForeColor = Color.FromArgb(240, 237, 226);
            panel10.Location = new Point(3, 69);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(0, 3, 0, 0);
            panel10.Size = new Size(299, 47);
            panel10.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(240, 237, 226);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Dock = DockStyle.Fill;
            textBox6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(0, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(299, 43);
            textBox6.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(monthLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(83, 141);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(305, 132);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthComboBox.BackColor = Color.FromArgb(240, 237, 226);
            monthComboBox.FlatStyle = FlatStyle.Flat;
            monthComboBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May ", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(3, 69);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(299, 53);
            monthComboBox.TabIndex = 6;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // monthLabel
            // 
            monthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            monthLabel.Location = new Point(3, 36);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(82, 30);
            monthLabel.TabIndex = 16;
            monthLabel.Text = "Month:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel3, 0, 1);
            tableLayoutPanel5.Controls.Add(yearLabel, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(409, 141);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(305, 132);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(240, 237, 226);
            panel3.Controls.Add(yearTextBox);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 3, 0, 0);
            panel3.Size = new Size(299, 47);
            panel3.TabIndex = 17;
            panel3.Paint += panel3_Paint;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.FromArgb(240, 237, 226);
            yearTextBox.BorderStyle = BorderStyle.None;
            yearTextBox.Dock = DockStyle.Fill;
            yearTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            yearTextBox.Location = new Point(0, 3);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(299, 43);
            yearTextBox.TabIndex = 7;
            yearTextBox.TextChanged += yearTextBox_TextChanged;
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            yearLabel.Location = new Point(3, 36);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(59, 30);
            yearLabel.TabIndex = 17;
            yearLabel.Text = "Year:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(240, 237, 226);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Location = new Point(83, 308);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(631, 120);
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Size = new Size(619, 108);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // ChargeSlipCheckBox
            // 
            ChargeSlipCheckBox.Anchor = AnchorStyles.Left;
            ChargeSlipCheckBox.AutoSize = true;
            ChargeSlipCheckBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ChargeSlipCheckBox.Location = new Point(3, 4);
            ChargeSlipCheckBox.Name = "ChargeSlipCheckBox";
            ChargeSlipCheckBox.Size = new Size(143, 34);
            ChargeSlipCheckBox.TabIndex = 0;
            ChargeSlipCheckBox.Text = "Charge Slip";
            ChargeSlipCheckBox.UseVisualStyleBackColor = true;
            ChargeSlipCheckBox.CheckedChanged += ChargeSlipCheckBox_CheckedChanged;
            // 
            // BillingStatementCheckBox
            // 
            BillingStatementCheckBox.Anchor = AnchorStyles.Left;
            BillingStatementCheckBox.AutoSize = true;
            BillingStatementCheckBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BillingStatementCheckBox.Location = new Point(312, 4);
            BillingStatementCheckBox.Name = "BillingStatementCheckBox";
            BillingStatementCheckBox.Size = new Size(194, 34);
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
            bsPopup.Location = new Point(312, 46);
            bsPopup.Name = "bsPopup";
            bsPopup.RowCount = 2;
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bsPopup.Size = new Size(304, 59);
            bsPopup.TabIndex = 17;
            bsPopup.Visible = false;
            bsPopup.Paint += bsPopup_Paint;
            // 
            // hmoLabel
            // 
            hmoLabel.Anchor = AnchorStyles.Right;
            hmoLabel.AutoSize = true;
            hmoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hmoLabel.Location = new Point(10, 29);
            hmoLabel.Margin = new Padding(0);
            hmoLabel.Name = "hmoLabel";
            hmoLabel.Size = new Size(35, 30);
            hmoLabel.TabIndex = 3;
            hmoLabel.Text = "HMO:";
            // 
            // bsNameTitle
            // 
            bsNameTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bsNameTitle.BorderStyle = BorderStyle.None;
            bsNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bsNameTitle.Location = new Point(48, 3);
            bsNameTitle.Name = "bsNameTitle";
            bsNameTitle.Size = new Size(253, 22);
            bsNameTitle.TabIndex = 0;
            bsNameTitle.TextChanged += bsNameTitle_TextChanged;
            // 
            // hmoTitle
            // 
            hmoTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hmoTitle.BorderStyle = BorderStyle.None;
            hmoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hmoTitle.Location = new Point(48, 33);
            hmoTitle.Name = "hmoTitle";
            hmoTitle.Size = new Size(253, 22);
            hmoTitle.TabIndex = 1;
            hmoTitle.TextChanged += hmoTitle_TextChanged;
            // 
            // bsNameLabel
            // 
            bsNameLabel.Anchor = AnchorStyles.Right;
            bsNameLabel.AutoSize = true;
            bsNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bsNameLabel.Location = new Point(3, 4);
            bsNameLabel.Margin = new Padding(0);
            bsNameLabel.Name = "bsNameLabel";
            bsNameLabel.Size = new Size(42, 21);
            bsNameLabel.TabIndex = 2;
            bsNameLabel.Text = "Title:";
            bsNameLabel.Click += label1_Click;
            // 
            // csSuggestion
            // 
            csSuggestion.AutoSize = true;
            csSuggestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            csSuggestion.Location = new Point(3, 43);
            csSuggestion.Name = "csSuggestion";
            csSuggestion.Size = new Size(290, 42);
            csSuggestion.TabIndex = 18;
            csSuggestion.Text = "Suggestion for printing: A4, Portrait, Fit All Columns on One Page";
            csSuggestion.Visible = false;
            csSuggestion.Click += label1_Click_1;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.None;
            exportButton.BackColor = Color.FromArgb(149, 176, 115);
            exportButton.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.SetColumnSpan(exportButton, 3);
            exportButton.FlatAppearance.BorderColor = Color.FromArgb(149, 176, 115);
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.ForeColor = Color.FromArgb(36, 49, 34);
            exportButton.Location = new Point(223, 480);
            exportButton.Margin = new Padding(0);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(350, 56);
            exportButton.TabIndex = 10;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(240, 237, 226);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(Header);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 600);
            panel2.TabIndex = 17;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.BackColor = Color.FromArgb(240, 237, 226);
            Header.Dock = DockStyle.Top;
            Header.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            Header.ForeColor = Color.FromArgb(36, 49, 34);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(357, 59);
            Header.TabIndex = 3;
            Header.Text = "Export Template";
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
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            bsPopup.ResumeLayout(false);
            bsPopup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox monthComboBox;
        private Label monthLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label yearLabel;
        private TextBox yearTextBox;
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
        private Label Header;
        private Panel panel;
        private Panel yearBorder;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label6;
        private Panel panel10;
        private TextBox textBox6;
        private Button exportButton;
    }
}
