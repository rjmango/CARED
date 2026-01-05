namespace CARED
{
    partial class newForm
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
            sidePanel = new Panel();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            contentPanel = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            sidePanel.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            contentPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(36, 48, 34);
            sidePanel.Controls.Add(panel5);
            sidePanel.Controls.Add(panel4);
            sidePanel.Controls.Add(panel2);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(0);
            sidePanel.MinimumSize = new Size(100, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(217, 1041);
            sidePanel.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(36, 48, 34);
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(217, 841);
            panel5.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(36, 48, 34);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(217, 170);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(10, 115);
            button3.Margin = new Padding(0, 5, 0, 5);
            button3.Name = "button3";
            button3.Size = new Size(197, 40);
            button3.TabIndex = 2;
            button3.Text = "Print Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(10, 65);
            button2.Margin = new Padding(0, 5, 0, 5);
            button2.Name = "button2";
            button2.Size = new Size(197, 40);
            button2.TabIndex = 1;
            button2.Text = "Retrieve Records";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(10, 15);
            button1.Margin = new Padding(0, 5, 0, 5);
            button1.Name = "button1";
            button1.Size = new Size(197, 40);
            button1.TabIndex = 0;
            button1.Text = "New Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(36, 48, 34);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 941);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 100);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 48, 34);
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 15, 0, 0);
            panel2.Size = new Size(217, 100);
            panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(36, 48, 34);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(148, 176, 114);
            textBox2.Location = new Point(0, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 32);
            textBox2.TabIndex = 0;
            textBox2.Text = "CARED System";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(240, 237, 226);
            contentPanel.Controls.Add(panel1);
            contentPanel.Controls.Add(panel3);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(217, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1687, 1041);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1687, 977);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(1687, 64);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 237, 226);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(36, 48, 34);
            textBox1.Location = new Point(5, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1677, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "Control Name";
            // 
            // newForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            Name = "newForm";
            Text = "newForm";
            sidePanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contentPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel contentPanel;
        private Panel panel3;
        private Panel panel1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
    }
}