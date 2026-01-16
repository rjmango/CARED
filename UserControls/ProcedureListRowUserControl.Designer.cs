namespace CARED.UserControls
{
    partial class ProcedureListRowUserControl
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
            pricePanel = new Panel();
            priceTextbox = new TextBox();
            procedurePanel = new Panel();
            procedureDropdown = new ComboBox();
            buttonPanel = new Panel();
            deleteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            pricePanel.SuspendLayout();
            procedurePanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(pricePanel, 1, 0);
            tableLayoutPanel1.Controls.Add(procedurePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonPanel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(820, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pricePanel
            // 
            pricePanel.AutoSize = true;
            pricePanel.Controls.Add(priceTextbox);
            pricePanel.Dock = DockStyle.Fill;
            pricePanel.Location = new Point(454, 3);
            pricePanel.Name = "pricePanel";
            pricePanel.Padding = new Padding(10, 10, 10, 0);
            pricePanel.Size = new Size(281, 54);
            pricePanel.TabIndex = 2;
            // 
            // priceTextbox
            // 
            priceTextbox.BackColor = Color.White;
            priceTextbox.BorderStyle = BorderStyle.FixedSingle;
            priceTextbox.Dock = DockStyle.Top;
            priceTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextbox.Location = new Point(10, 10);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.ReadOnly = true;
            priceTextbox.Size = new Size(261, 29);
            priceTextbox.TabIndex = 1;
            priceTextbox.TabStop = false;
            priceTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // procedurePanel
            // 
            procedurePanel.AutoSize = true;
            procedurePanel.Controls.Add(procedureDropdown);
            procedurePanel.Dock = DockStyle.Fill;
            procedurePanel.Location = new Point(3, 3);
            procedurePanel.Name = "procedurePanel";
            procedurePanel.Padding = new Padding(10, 10, 10, 0);
            procedurePanel.Size = new Size(445, 54);
            procedurePanel.TabIndex = 1;
            // 
            // procedureDropdown
            // 
            procedureDropdown.Dock = DockStyle.Top;
            procedureDropdown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            procedureDropdown.FormattingEnabled = true;
            procedureDropdown.Location = new Point(10, 10);
            procedureDropdown.Name = "procedureDropdown";
            procedureDropdown.Size = new Size(425, 29);
            procedureDropdown.TabIndex = 1;
            procedureDropdown.SelectedIndexChanged += procedureDropdown_SelectedIndexChanged;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(741, 3);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(10, 5, 10, 10);
            buttonPanel.Size = new Size(76, 54);
            buttonPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 94, 104);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(10, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(56, 39);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // ProcedureListRowUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(240, 237, 227);
            Controls.Add(tableLayoutPanel1);
            Name = "ProcedureListRowUserControl";
            Size = new Size(820, 60);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            procedurePanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel procedurePanel;
        private Panel pricePanel;
        private ComboBox procedureDropdown;
        private TextBox priceTextbox;
        private Panel buttonPanel;
        private Button deleteButton;
    }
}
