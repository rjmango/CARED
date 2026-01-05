namespace CARED
{
    partial class Printing
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button3, 2, 4);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(968, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(196, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(582, 151);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(187, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(196, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "From:";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(582, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "Until:";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(389, 299);
            button3.Name = "button3";
            button3.Size = new Size(187, 52);
            button3.TabIndex = 8;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Charge Slips", "Billing Statements" });
            comboBox1.Location = new Point(389, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 9;
            // 
            // Printing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Printing";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button button3;
        private ComboBox comboBox1;
    }
}