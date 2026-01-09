using System;
using System.Windows.Forms;
using CARED.Services;
using System.Collections.Generic;
using CARED.Models;

namespace CARED
{
    public partial class printForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            printButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            ChargeSlipCheckBox = new CheckBox();
            BillingStatementCheckBox = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Controls.Add(printButton, 2, 4);
            tableLayoutPanel1.Controls.Add(panel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(filenameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(fileNameTextBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(163, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(154, 84);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // filenameLabel
            // 
            filenameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(3, 27);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(63, 15);
            filenameLabel.TabIndex = 17;
            filenameLabel.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameTextBox.Location = new Point(3, 45);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(148, 23);
            fileNameTextBox.TabIndex = 8;
            fileNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(monthLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(163, 183);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(154, 84);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May ", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(3, 45);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(148, 23);
            monthComboBox.TabIndex = 6;
            monthComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // monthLabel
            // 
            monthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(3, 27);
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
            tableLayoutPanel3.Location = new Point(163, 93);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(154, 84);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // insurerComboBox
            // 
            insurerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            insurerComboBox.FormattingEnabled = true;
            insurerComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May ", "June", "July", "August", "September", "October", "November", "December" });
            insurerComboBox.Location = new Point(3, 45);
            insurerComboBox.Name = "insurerComboBox";
            insurerComboBox.Size = new Size(148, 23);
            insurerComboBox.TabIndex = 18;
            insurerComboBox.SelectedIndexChanged += insurerComboBox_SelectedIndexChanged;
            // 
            // insurerLabel
            // 
            insurerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            insurerLabel.AutoSize = true;
            insurerLabel.Location = new Point(3, 27);
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
            tableLayoutPanel5.Location = new Point(483, 183);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(154, 84);
            tableLayoutPanel5.TabIndex = 15;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(3, 27);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 17;
            yearLabel.Text = "Year:";
            yearLabel.Click += yearLabel_Click;
            // 
            // yearTextBox
            // 
            yearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yearTextBox.Location = new Point(3, 45);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(148, 23);
            yearTextBox.TabIndex = 7;
            yearTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // printButton
            // 
            printButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            printButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            printButton.Location = new Point(323, 363);
            printButton.Name = "printButton";
            printButton.Size = new Size(154, 56);
            printButton.TabIndex = 10;
            printButton.Text = "Export";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(36, 48, 34);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Location = new Point(163, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 42);
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
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(474, 42);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // ChargeSlipCheckBox
            // 
            ChargeSlipCheckBox.Anchor = AnchorStyles.Left;
            ChargeSlipCheckBox.AutoSize = true;
            ChargeSlipCheckBox.Location = new Point(3, 11);
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
            BillingStatementCheckBox.Location = new Point(240, 11);
            BillingStatementCheckBox.Name = "BillingStatementCheckBox";
            BillingStatementCheckBox.Size = new Size(116, 19);
            BillingStatementCheckBox.TabIndex = 1;
            BillingStatementCheckBox.Text = "Billing Statement";
            BillingStatementCheckBox.UseVisualStyleBackColor = true;
            BillingStatementCheckBox.CheckedChanged += BillingStatementCheckBox_CheckedChanged;
            // 
            // printForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "printForm";
            Text = "Form1";
            Load += printForm_Load;
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
            ResumeLayout(false);
        }

        #endregion

        // Inject the Service Layer through the constructor
        private readonly IProcedureService _procedureService;
        public printForm(IProcedureService procedureService)
        {
            InitializeComponent();
            _procedureService = procedureService;
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox fileNameTextBox;
        private TextBox yearTextBox;
        private Button printButton;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox6;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox monthComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox7;
        private Label monthLabel;
        private Label filenameLabel;
        private Label insurerLabel;
        private Label yearLabel;
        private ComboBox insurerComboBox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox ChargeSlipCheckBox;
        private CheckBox BillingStatementCheckBox;
    }
}
