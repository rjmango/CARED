namespace CARED.UserControls
{
    partial class RetrieveRecordsUserControl
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
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            transactionBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            button2 = new Button();
            csNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactedProceduresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personnelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(412, 81);
            label1.TabIndex = 1;
            label1.Text = "View Records";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1152, 132);
            button1.Name = "button1";
            button1.Size = new Size(91, 43);
            button1.TabIndex = 2;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { csNoDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, transactedProceduresDataGridViewTextBoxColumn, personnelDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.Location = new Point(3, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1240, 667);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(32, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1015, 43);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1044, 132);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // csNoDataGridViewTextBoxColumn
            // 
            csNoDataGridViewTextBoxColumn.DataPropertyName = "CsNo";
            csNoDataGridViewTextBoxColumn.HeaderText = "CS Number";
            csNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            csNoDataGridViewTextBoxColumn.Name = "csNoDataGridViewTextBoxColumn";
            csNoDataGridViewTextBoxColumn.ReadOnly = true;
            csNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactedProceduresDataGridViewTextBoxColumn
            // 
            transactedProceduresDataGridViewTextBoxColumn.DataPropertyName = "TransactedProcedures";
            transactedProceduresDataGridViewTextBoxColumn.HeaderText = "Laboratory Requests";
            transactedProceduresDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactedProceduresDataGridViewTextBoxColumn.Name = "transactedProceduresDataGridViewTextBoxColumn";
            transactedProceduresDataGridViewTextBoxColumn.ReadOnly = true;
            transactedProceduresDataGridViewTextBoxColumn.Width = 200;
            // 
            // personnelDataGridViewTextBoxColumn
            // 
            personnelDataGridViewTextBoxColumn.DataPropertyName = "Personnel";
            personnelDataGridViewTextBoxColumn.HeaderText = "Doctor";
            personnelDataGridViewTextBoxColumn.MinimumWidth = 6;
            personnelDataGridViewTextBoxColumn.Name = "personnelDataGridViewTextBoxColumn";
            personnelDataGridViewTextBoxColumn.ReadOnly = true;
            personnelDataGridViewTextBoxColumn.Width = 125;
            // 
            // RetrieveRecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RetrieveRecordsUserControl";
            Size = new Size(1280, 880);
            Load += RetrieveRecordsUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn csNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactedProceduresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
    }
}
