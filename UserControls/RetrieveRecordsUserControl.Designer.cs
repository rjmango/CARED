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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            transactionBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
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
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(329, 65);
            label1.TabIndex = 1;
            label1.Text = "View Records";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { csNoDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, transactedProceduresDataGridViewTextBoxColumn, personnelDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Location = new Point(18, 150);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1085, 495);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(18, 99);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Name, CS No, or Company...";
            textBox1.Size = new Size(1060, 36);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "RetrieveRecordsUserControl";
            Size = new Size(1120, 660);
            Load += RetrieveRecordsUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn csNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactedProceduresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
    }
}
