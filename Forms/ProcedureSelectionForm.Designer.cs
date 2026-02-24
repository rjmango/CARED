namespace CARED.Forms
{
    partial class ProcedureSelectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            LaboratoryTestsPanel = new Panel();
            LaboratoryTestsCheckedListBox = new CheckedListBox();
            LaboratoryTestsLabel = new Label();
            ImagingServicesPanel = new Panel();
            ImagingServicesCheckedListBox = new CheckedListBox();
            ImagingServicesLabel = new Label();
            UltrasoundServicesPanel = new Panel();
            UltrasoundServicesCheckedListBox = new CheckedListBox();
            UltrasoundServicesLabel = new Label();
            ConfirmButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            LaboratoryTestsPanel.SuspendLayout();
            ImagingServicesPanel.SuspendLayout();
            UltrasoundServicesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(LaboratoryTestsPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(ImagingServicesPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(UltrasoundServicesPanel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(855, 346);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LaboratoryTestsPanel
            // 
            LaboratoryTestsPanel.AutoSize = true;
            LaboratoryTestsPanel.Controls.Add(LaboratoryTestsCheckedListBox);
            LaboratoryTestsPanel.Controls.Add(LaboratoryTestsLabel);
            LaboratoryTestsPanel.Dock = DockStyle.Fill;
            LaboratoryTestsPanel.Location = new Point(3, 3);
            LaboratoryTestsPanel.Name = "LaboratoryTestsPanel";
            LaboratoryTestsPanel.Padding = new Padding(2);
            LaboratoryTestsPanel.Size = new Size(278, 340);
            LaboratoryTestsPanel.TabIndex = 0;
            // 
            // LaboratoryTestsCheckedListBox
            // 
            LaboratoryTestsCheckedListBox.CheckOnClick = true;
            LaboratoryTestsCheckedListBox.Dock = DockStyle.Top;
            LaboratoryTestsCheckedListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LaboratoryTestsCheckedListBox.FormattingEnabled = true;
            LaboratoryTestsCheckedListBox.Location = new Point(2, 26);
            LaboratoryTestsCheckedListBox.Name = "LaboratoryTestsCheckedListBox";
            LaboratoryTestsCheckedListBox.Size = new Size(274, 312);
            LaboratoryTestsCheckedListBox.Sorted = true;
            LaboratoryTestsCheckedListBox.TabIndex = 1;
            // 
            // LaboratoryTestsLabel
            // 
            LaboratoryTestsLabel.AutoSize = true;
            LaboratoryTestsLabel.Dock = DockStyle.Top;
            LaboratoryTestsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LaboratoryTestsLabel.Location = new Point(2, 2);
            LaboratoryTestsLabel.Name = "LaboratoryTestsLabel";
            LaboratoryTestsLabel.Padding = new Padding(0, 0, 0, 3);
            LaboratoryTestsLabel.Size = new Size(160, 24);
            LaboratoryTestsLabel.TabIndex = 0;
            LaboratoryTestsLabel.Text = "LABORATORY TESTS";
            // 
            // ImagingServicesPanel
            // 
            ImagingServicesPanel.AutoSize = true;
            ImagingServicesPanel.Controls.Add(ImagingServicesCheckedListBox);
            ImagingServicesPanel.Controls.Add(ImagingServicesLabel);
            ImagingServicesPanel.Dock = DockStyle.Fill;
            ImagingServicesPanel.Location = new Point(287, 3);
            ImagingServicesPanel.Name = "ImagingServicesPanel";
            ImagingServicesPanel.Padding = new Padding(2);
            ImagingServicesPanel.Size = new Size(278, 340);
            ImagingServicesPanel.TabIndex = 1;
            // 
            // ImagingServicesCheckedListBox
            // 
            ImagingServicesCheckedListBox.CheckOnClick = true;
            ImagingServicesCheckedListBox.Dock = DockStyle.Top;
            ImagingServicesCheckedListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ImagingServicesCheckedListBox.FormattingEnabled = true;
            ImagingServicesCheckedListBox.Location = new Point(2, 26);
            ImagingServicesCheckedListBox.Name = "ImagingServicesCheckedListBox";
            ImagingServicesCheckedListBox.Size = new Size(274, 312);
            ImagingServicesCheckedListBox.TabIndex = 2;
            // 
            // ImagingServicesLabel
            // 
            ImagingServicesLabel.AutoSize = true;
            ImagingServicesLabel.Dock = DockStyle.Top;
            ImagingServicesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ImagingServicesLabel.Location = new Point(2, 2);
            ImagingServicesLabel.Name = "ImagingServicesLabel";
            ImagingServicesLabel.Padding = new Padding(0, 0, 0, 3);
            ImagingServicesLabel.Size = new Size(157, 24);
            ImagingServicesLabel.TabIndex = 1;
            ImagingServicesLabel.Text = "IMAGING SERVICES";
            // 
            // UltrasoundServicesPanel
            // 
            UltrasoundServicesPanel.AutoSize = true;
            UltrasoundServicesPanel.Controls.Add(UltrasoundServicesCheckedListBox);
            UltrasoundServicesPanel.Controls.Add(UltrasoundServicesLabel);
            UltrasoundServicesPanel.Dock = DockStyle.Fill;
            UltrasoundServicesPanel.Location = new Point(571, 3);
            UltrasoundServicesPanel.Name = "UltrasoundServicesPanel";
            UltrasoundServicesPanel.Padding = new Padding(2);
            UltrasoundServicesPanel.Size = new Size(281, 340);
            UltrasoundServicesPanel.TabIndex = 2;
            // 
            // UltrasoundServicesCheckedListBox
            // 
            UltrasoundServicesCheckedListBox.CheckOnClick = true;
            UltrasoundServicesCheckedListBox.Dock = DockStyle.Top;
            UltrasoundServicesCheckedListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UltrasoundServicesCheckedListBox.FormattingEnabled = true;
            UltrasoundServicesCheckedListBox.Location = new Point(2, 26);
            UltrasoundServicesCheckedListBox.Name = "UltrasoundServicesCheckedListBox";
            UltrasoundServicesCheckedListBox.Size = new Size(277, 312);
            UltrasoundServicesCheckedListBox.TabIndex = 3;
            // 
            // UltrasoundServicesLabel
            // 
            UltrasoundServicesLabel.AutoSize = true;
            UltrasoundServicesLabel.Dock = DockStyle.Top;
            UltrasoundServicesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UltrasoundServicesLabel.Location = new Point(2, 2);
            UltrasoundServicesLabel.Name = "UltrasoundServicesLabel";
            UltrasoundServicesLabel.Padding = new Padding(0, 0, 0, 3);
            UltrasoundServicesLabel.Size = new Size(193, 24);
            UltrasoundServicesLabel.TabIndex = 2;
            UltrasoundServicesLabel.Text = "ULTRASOUND SERVICES";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(36, 48, 34);
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmButton.ForeColor = SystemColors.ControlLightLight;
            ConfirmButton.Location = new Point(12, 407);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(131, 42);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "CONFIRM";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            ConfirmButton.Paint += ConfirmButton_Paint;
            // 
            // ProcedureSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 226);
            ClientSize = new Size(855, 461);
            Controls.Add(ConfirmButton);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProcedureSelectionForm";
            Text = "ProcedureSelectionForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            LaboratoryTestsPanel.ResumeLayout(false);
            LaboratoryTestsPanel.PerformLayout();
            ImagingServicesPanel.ResumeLayout(false);
            ImagingServicesPanel.PerformLayout();
            UltrasoundServicesPanel.ResumeLayout(false);
            UltrasoundServicesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel LaboratoryTestsPanel;
        private Panel ImagingServicesPanel;
        private Panel UltrasoundServicesPanel;
        private Label LaboratoryTestsLabel;
        private Label ImagingServicesLabel;
        private Label UltrasoundServicesLabel;
        private CheckedListBox LaboratoryTestsCheckedListBox;
        private CheckedListBox ImagingServicesCheckedListBox;
        private CheckedListBox UltrasoundServicesCheckedListBox;
        private Button ConfirmButton;
    }
}