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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedureListRowUserControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            pricePanel = new Panel();
            priceTextbox = new TextBox();
            procedurePanel = new Panel();
            procedureDropdown = new ComboBox();
            buttonPanel = new Panel();
            deleteButton = new Button();
            imageList1 = new ImageList(components);
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
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(760, 53);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pricePanel
            // 
            pricePanel.AutoSize = true;
            pricePanel.Controls.Add(priceTextbox);
            pricePanel.Dock = DockStyle.Fill;
            pricePanel.Location = new Point(422, 3);
            pricePanel.Margin = new Padding(4, 3, 4, 3);
            pricePanel.Name = "pricePanel";
            pricePanel.Padding = new Padding(8, 8, 8, 0);
            pricePanel.Size = new Size(258, 47);
            pricePanel.TabIndex = 2;
            // 
            // priceTextbox
            // 
            priceTextbox.BackColor = Color.White;
            priceTextbox.BorderStyle = BorderStyle.FixedSingle;
            priceTextbox.Dock = DockStyle.Top;
            priceTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextbox.Location = new Point(8, 8);
            priceTextbox.Margin = new Padding(4, 3, 4, 3);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.ReadOnly = true;
            priceTextbox.Size = new Size(242, 29);
            priceTextbox.TabIndex = 1;
            priceTextbox.TabStop = false;
            priceTextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // procedurePanel
            // 
            procedurePanel.AutoSize = true;
            procedurePanel.Controls.Add(procedureDropdown);
            procedurePanel.Dock = DockStyle.Fill;
            procedurePanel.Location = new Point(4, 3);
            procedurePanel.Margin = new Padding(4, 3, 4, 3);
            procedurePanel.Name = "procedurePanel";
            procedurePanel.Padding = new Padding(8, 8, 8, 0);
            procedurePanel.Size = new Size(410, 47);
            procedurePanel.TabIndex = 1;
            // 
            // procedureDropdown
            // 
            procedureDropdown.Dock = DockStyle.Top;
            procedureDropdown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            procedureDropdown.FormattingEnabled = true;
            procedureDropdown.Location = new Point(8, 8);
            procedureDropdown.Margin = new Padding(4, 3, 4, 3);
            procedureDropdown.Name = "procedureDropdown";
            procedureDropdown.Size = new Size(394, 29);
            procedureDropdown.TabIndex = 1;
            procedureDropdown.SelectedIndexChanged += procedureDropdown_SelectedIndexChanged;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(688, 3);
            buttonPanel.Margin = new Padding(4, 3, 4, 3);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(11, 7, 11, 8);
            buttonPanel.Size = new Size(68, 47);
            buttonPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 94, 104);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(11, 7);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(46, 32);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "X";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseMnemonic = false;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-trash-52.png");
            // 
            // ProcedureListRowUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(240, 237, 227);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProcedureListRowUserControl";
            Size = new Size(760, 53);
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
        private ImageList imageList1;
    }
}
