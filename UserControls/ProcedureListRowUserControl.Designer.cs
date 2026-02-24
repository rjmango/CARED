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
            procedureTextbox = new TextBox();
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(pricePanel, 1, 0);
            tableLayoutPanel1.Controls.Add(procedurePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonPanel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 0, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(760, 24);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pricePanel
            // 
            pricePanel.AutoSize = true;
            pricePanel.Controls.Add(priceTextbox);
            pricePanel.Dock = DockStyle.Fill;
            pricePanel.Location = new Point(422, 1);
            pricePanel.Margin = new Padding(4, 1, 4, 3);
            pricePanel.Name = "pricePanel";
            pricePanel.Padding = new Padding(8, 0, 8, 0);
            pricePanel.Size = new Size(258, 40);
            pricePanel.TabIndex = 2;
            // 
            // priceTextbox
            // 
            priceTextbox.BackColor = Color.White;
            priceTextbox.BorderStyle = BorderStyle.None;
            priceTextbox.Dock = DockStyle.Top;
            priceTextbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextbox.Location = new Point(8, 0);
            priceTextbox.Margin = new Padding(4, 3, 4, 3);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.ReadOnly = true;
            priceTextbox.Size = new Size(242, 20);
            priceTextbox.TabIndex = 1;
            priceTextbox.TabStop = false;
            // 
            // procedurePanel
            // 
            procedurePanel.AutoSize = true;
            procedurePanel.Controls.Add(procedureTextbox);
            procedurePanel.Dock = DockStyle.Fill;
            procedurePanel.Location = new Point(4, 1);
            procedurePanel.Margin = new Padding(4, 1, 4, 3);
            procedurePanel.Name = "procedurePanel";
            procedurePanel.Padding = new Padding(8, 0, 8, 0);
            procedurePanel.Size = new Size(410, 40);
            procedurePanel.TabIndex = 1;
            // 
            // procedureTextbox
            // 
            procedureTextbox.BackColor = Color.White;
            procedureTextbox.BorderStyle = BorderStyle.None;
            procedureTextbox.Dock = DockStyle.Top;
            procedureTextbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            procedureTextbox.Location = new Point(8, 0);
            procedureTextbox.Margin = new Padding(4, 3, 4, 3);
            procedureTextbox.Name = "procedureTextbox";
            procedureTextbox.ReadOnly = true;
            procedureTextbox.RightToLeft = RightToLeft.No;
            procedureTextbox.Size = new Size(394, 20);
            procedureTextbox.TabIndex = 2;
            procedureTextbox.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(688, 1);
            buttonPanel.Margin = new Padding(4, 1, 4, 3);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(11, 0, 11, 0);
            buttonPanel.Size = new Size(68, 40);
            buttonPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(240, 237, 227);
            deleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteButton.FlatAppearance.BorderColor = Color.FromArgb(238, 94, 104);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ImageIndex = 0;
            deleteButton.ImageList = imageList1;
            deleteButton.Location = new Point(20, 0);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(0, 0, 1, 5);
            deleteButton.Size = new Size(28, 23);
            deleteButton.TabIndex = 0;
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseMnemonic = false;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            deleteButton.MouseEnter += deleteButton_MouseEnter;
            deleteButton.MouseLeave += deleteButton_MouseLeave;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-trash-can-100.png");
            imageList1.Images.SetKeyName(1, "icons8-trash-can-100-red.png");
            // 
            // ProcedureListRowUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 227);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 0, 4, 0);
            Name = "ProcedureListRowUserControl";
            Size = new Size(760, 24);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            procedurePanel.ResumeLayout(false);
            procedurePanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel procedurePanel;
        private Panel pricePanel;
        private TextBox priceTextbox;
        private Panel buttonPanel;
        private Button deleteButton;
        private ImageList imageList1;
        private TextBox procedureTextbox;
    }
}
