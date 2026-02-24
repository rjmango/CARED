using CARED.Services; // Assuming your service interfaces are here
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CARED.UserControls
{
    public partial class NewBillingUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       

        public NewBillingUserControl()
        {
            InitializeComponent();
        }
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

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 10; // Slightly smaller radius looks better for buttons

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 25; // Adjust for more or less roundness

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(contentPanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(contentPanel.Width - radius, contentPanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, contentPanel.Height - radius, radius, radius, 90, 90);

            contentPanel.Region = new Region(path);
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            headerLabel = new Label();
            contentPanel = new Panel();
            totalPricePanel = new TableLayoutPanel();
            saveButton = new Button();
            panel1 = new Panel();
            totalAmount = new Label();
            totalAmountLabel = new Label();
            buttonPanel = new FlowLayoutPanel();
            addProcedureButton = new Button();
            procedureRowsPanel = new Panel();
            procedureSelectionPlaceholder = new Label();
            procedureListLabelLayout = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            paddingPanel = new Panel();
            bottomGreenLine = new Label();
            proceduresLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            personnelInputPanel = new Panel();
            personnelPanel = new Panel();
            personnelTextbox = new TextBox();
            personnelLabel = new Label();
            companyInputPanel = new Panel();
            companyPanel = new Panel();
            companyTextbox = new TextBox();
            companyLabel = new Label();
            patientDetailsTableLayout = new TableLayoutPanel();
            patientNameInputPanel = new Panel();
            patientNamePanel = new Panel();
            patientNameTextbox = new TextBox();
            patientNameLabel = new Label();
            csNoInputPanel = new Panel();
            csNoPanel = new Panel();
            csNoTextbox = new TextBox();
            csNoLabel = new Label();
            dateInputPanel = new Panel();
            datePanel = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dateLabel = new Label();
            topGreenLine = new Label();
            patientDetailsLabel = new Label();
            addProcedureDisabledTooltip = new ToolTip(components);
            contentPanel.SuspendLayout();
            totalPricePanel.SuspendLayout();
            panel1.SuspendLayout();
            buttonPanel.SuspendLayout();
            procedureRowsPanel.SuspendLayout();
            procedureListLabelLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            personnelInputPanel.SuspendLayout();
            personnelPanel.SuspendLayout();
            companyInputPanel.SuspendLayout();
            companyPanel.SuspendLayout();
            patientDetailsTableLayout.SuspendLayout();
            patientNameInputPanel.SuspendLayout();
            patientNamePanel.SuspendLayout();
            csNoInputPanel.SuspendLayout();
            csNoPanel.SuspendLayout();
            dateInputPanel.SuspendLayout();
            datePanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(36, 49, 34);
            headerLabel.Location = new Point(4, 3);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(264, 40);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "New Record Entry";
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(totalPricePanel);
            contentPanel.Controls.Add(buttonPanel);
            contentPanel.Controls.Add(procedureRowsPanel);
            contentPanel.Controls.Add(procedureListLabelLayout);
            contentPanel.Controls.Add(paddingPanel);
            contentPanel.Controls.Add(bottomGreenLine);
            contentPanel.Controls.Add(proceduresLabel);
            contentPanel.Controls.Add(tableLayoutPanel1);
            contentPanel.Controls.Add(patientDetailsTableLayout);
            contentPanel.Controls.Add(topGreenLine);
            contentPanel.Controls.Add(patientDetailsLabel);
            contentPanel.Location = new Point(4, 57);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20, 10, 20, 20);
            contentPanel.Size = new Size(791, 538);
            contentPanel.TabIndex = 2;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // totalPricePanel
            // 
            totalPricePanel.AutoSize = true;
            totalPricePanel.BackColor = Color.FromArgb(36, 48, 34);
            totalPricePanel.ColumnCount = 2;
            totalPricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            totalPricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            totalPricePanel.Controls.Add(saveButton, 1, 0);
            totalPricePanel.Controls.Add(panel1, 0, 0);
            totalPricePanel.Dock = DockStyle.Top;
            totalPricePanel.Location = new Point(20, 446);
            totalPricePanel.Name = "totalPricePanel";
            totalPricePanel.Padding = new Padding(5, 7, 5, 7);
            totalPricePanel.RightToLeft = RightToLeft.No;
            totalPricePanel.RowCount = 1;
            totalPricePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalPricePanel.Size = new Size(751, 87);
            totalPricePanel.TabIndex = 0;
            totalPricePanel.Resize += panel1_Resize;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(149, 176, 115);
            saveButton.Dock = DockStyle.Right;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Image = Properties.Resources.icons8_save_48;
            saveButton.ImageAlign = ContentAlignment.MiddleRight;
            saveButton.Location = new Point(541, 10);
            saveButton.Margin = new Padding(3, 3, 20, 3);
            saveButton.Name = "saveButton";
            saveButton.Padding = new Padding(5, 0, 0, 0);
            saveButton.RightToLeft = RightToLeft.Yes;
            saveButton.Size = new Size(185, 67);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save Record          ";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            saveButton.Paint += Button_Paint;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(totalAmount);
            panel1.Controls.Add(totalAmountLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 67);
            panel1.TabIndex = 2;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Dock = DockStyle.Top;
            totalAmount.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmount.ForeColor = Color.White;
            totalAmount.ImageAlign = ContentAlignment.MiddleLeft;
            totalAmount.Location = new Point(0, 21);
            totalAmount.Name = "totalAmount";
            totalAmount.RightToLeft = RightToLeft.Yes;
            totalAmount.Size = new Size(111, 46);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "00.00";
            totalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Dock = DockStyle.Top;
            totalAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmountLabel.ForeColor = Color.FromArgb(140, 169, 110);
            totalAmountLabel.Location = new Point(0, 0);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(132, 21);
            totalAmountLabel.TabIndex = 0;
            totalAmountLabel.Text = "TOTAL AMOUNT";
            // 
            // buttonPanel
            // 
            buttonPanel.AutoSize = true;
            buttonPanel.Controls.Add(addProcedureButton);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(20, 399);
            buttonPanel.Margin = new Padding(2, 3, 0, 3);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 4, 0, 4);
            buttonPanel.Size = new Size(751, 47);
            buttonPanel.TabIndex = 32;
            // 
            // addProcedureButton
            // 
            addProcedureButton.AutoSize = true;
            addProcedureButton.BackColor = Color.FromArgb(234, 239, 227);
            addProcedureButton.FlatAppearance.BorderSize = 0;
            addProcedureButton.FlatStyle = FlatStyle.Flat;
            addProcedureButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProcedureButton.ForeColor = Color.FromArgb(36, 48, 34);
            addProcedureButton.Location = new Point(0, 7);
            addProcedureButton.Margin = new Padding(0, 3, 3, 3);
            addProcedureButton.Name = "addProcedureButton";
            addProcedureButton.Size = new Size(148, 33);
            addProcedureButton.TabIndex = 0;
            addProcedureButton.Text = "+ Add Procedure";
            addProcedureButton.TextAlign = ContentAlignment.MiddleLeft;
            addProcedureButton.UseVisualStyleBackColor = false;
            addProcedureButton.Click += addProcedureButton_Click;
            addProcedureButton.Paint += Button_Paint;
            addProcedureButton.Resize += panel1_Resize;
            // 
            // procedureRowsPanel
            // 
            procedureRowsPanel.AutoScroll = true;
            procedureRowsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            procedureRowsPanel.BackColor = Color.FromArgb(240, 237, 227);
            procedureRowsPanel.Controls.Add(procedureSelectionPlaceholder);
            procedureRowsPanel.Dock = DockStyle.Top;
            procedureRowsPanel.ImeMode = ImeMode.Disable;
            procedureRowsPanel.Location = new Point(20, 248);
            procedureRowsPanel.Name = "procedureRowsPanel";
            procedureRowsPanel.Padding = new Padding(5, 0, 5, 10);
            procedureRowsPanel.Size = new Size(751, 151);
            procedureRowsPanel.TabIndex = 28;
            procedureRowsPanel.Resize += procedureRowsPanel_Resize;
            // 
            // procedureSelectionPlaceholder
            // 
            procedureSelectionPlaceholder.AutoSize = true;
            procedureSelectionPlaceholder.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            procedureSelectionPlaceholder.ForeColor = SystemColors.ControlDark;
            procedureSelectionPlaceholder.Location = new Point(254, 48);
            procedureSelectionPlaceholder.Name = "procedureSelectionPlaceholder";
            procedureSelectionPlaceholder.Size = new Size(243, 28);
            procedureSelectionPlaceholder.TabIndex = 0;
            procedureSelectionPlaceholder.Text = "Please select a procedure";
            procedureSelectionPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // procedureListLabelLayout
            // 
            procedureListLabelLayout.AutoSize = true;
            procedureListLabelLayout.BackColor = Color.FromArgb(240, 237, 227);
            procedureListLabelLayout.ColumnCount = 2;
            procedureListLabelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            procedureListLabelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            procedureListLabelLayout.Controls.Add(label2, 1, 0);
            procedureListLabelLayout.Controls.Add(label1, 0, 0);
            procedureListLabelLayout.Dock = DockStyle.Top;
            procedureListLabelLayout.Location = new Point(20, 220);
            procedureListLabelLayout.Name = "procedureListLabelLayout";
            procedureListLabelLayout.RowCount = 1;
            procedureListLabelLayout.RowStyles.Add(new RowStyle());
            procedureListLabelLayout.Size = new Size(751, 28);
            procedureListLabelLayout.TabIndex = 0;
            procedureListLabelLayout.Resize += procedureListLabelLayout_Resize;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(36, 49, 34);
            label2.Location = new Point(416, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 7, 0, 0);
            label2.Size = new Size(53, 28);
            label2.TabIndex = 1;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(36, 49, 34);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(12, 7, 0, 0);
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "Procedure";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paddingPanel
            // 
            paddingPanel.AutoSize = true;
            paddingPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paddingPanel.BackColor = Color.White;
            paddingPanel.Dock = DockStyle.Top;
            paddingPanel.Location = new Point(20, 210);
            paddingPanel.Name = "paddingPanel";
            paddingPanel.Padding = new Padding(0, 10, 0, 0);
            paddingPanel.Size = new Size(751, 10);
            paddingPanel.TabIndex = 29;
            // 
            // bottomGreenLine
            // 
            bottomGreenLine.BackColor = Color.FromArgb(148, 177, 114);
            bottomGreenLine.Dock = DockStyle.Top;
            bottomGreenLine.Location = new Point(20, 208);
            bottomGreenLine.Name = "bottomGreenLine";
            bottomGreenLine.Size = new Size(751, 2);
            bottomGreenLine.TabIndex = 24;
            // 
            // proceduresLabel
            // 
            proceduresLabel.AutoSize = true;
            proceduresLabel.Dock = DockStyle.Top;
            proceduresLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            proceduresLabel.ForeColor = Color.FromArgb(36, 49, 34);
            proceduresLabel.Location = new Point(20, 173);
            proceduresLabel.Margin = new Padding(0, 3, 3, 5);
            proceduresLabel.Name = "proceduresLabel";
            proceduresLabel.Padding = new Padding(0, 2, 0, 5);
            proceduresLabel.Size = new Size(114, 35);
            proceduresLabel.TabIndex = 23;
            proceduresLabel.Text = "Procedures";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(personnelInputPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(companyInputPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(20, 109);
            tableLayoutPanel1.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(751, 64);
            tableLayoutPanel1.TabIndex = 33;
            // 
            // personnelInputPanel
            // 
            personnelInputPanel.AutoSize = true;
            personnelInputPanel.Controls.Add(personnelPanel);
            personnelInputPanel.Controls.Add(personnelLabel);
            personnelInputPanel.Dock = DockStyle.Fill;
            personnelInputPanel.Location = new Point(3, 3);
            personnelInputPanel.Name = "personnelInputPanel";
            personnelInputPanel.Size = new Size(369, 58);
            personnelInputPanel.TabIndex = 3;
            // 
            // personnelPanel
            // 
            personnelPanel.BackColor = Color.FromArgb(240, 237, 227);
            personnelPanel.Controls.Add(personnelTextbox);
            personnelPanel.Dock = DockStyle.Top;
            personnelPanel.Location = new Point(0, 26);
            personnelPanel.Name = "personnelPanel";
            personnelPanel.Padding = new Padding(15, 7, 15, 0);
            personnelPanel.Size = new Size(369, 32);
            personnelPanel.TabIndex = 21;
            personnelPanel.Resize += panel1_Resize;
            // 
            // personnelTextbox
            // 
            personnelTextbox.BackColor = Color.FromArgb(240, 237, 227);
            personnelTextbox.BorderStyle = BorderStyle.None;
            personnelTextbox.Dock = DockStyle.Fill;
            personnelTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            personnelTextbox.Location = new Point(15, 7);
            personnelTextbox.Name = "personnelTextbox";
            personnelTextbox.PlaceholderText = "Accomodated by";
            personnelTextbox.Size = new Size(339, 18);
            personnelTextbox.TabIndex = 9;
            personnelTextbox.Leave += personnelTextbox_Leave;
            // 
            // personnelLabel
            // 
            personnelLabel.AutoSize = true;
            personnelLabel.Dock = DockStyle.Top;
            personnelLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            personnelLabel.ForeColor = Color.FromArgb(36, 49, 34);
            personnelLabel.Location = new Point(0, 0);
            personnelLabel.Name = "personnelLabel";
            personnelLabel.Padding = new Padding(0, 2, 0, 5);
            personnelLabel.Size = new Size(134, 26);
            personnelLabel.TabIndex = 14;
            personnelLabel.Text = "Personnel In-charge";
            // 
            // companyInputPanel
            // 
            companyInputPanel.AutoSize = true;
            companyInputPanel.Controls.Add(companyPanel);
            companyInputPanel.Controls.Add(companyLabel);
            companyInputPanel.Dock = DockStyle.Fill;
            companyInputPanel.Location = new Point(378, 3);
            companyInputPanel.Name = "companyInputPanel";
            companyInputPanel.Size = new Size(370, 58);
            companyInputPanel.TabIndex = 4;
            // 
            // companyPanel
            // 
            companyPanel.BackColor = Color.FromArgb(240, 237, 227);
            companyPanel.Controls.Add(companyTextbox);
            companyPanel.Dock = DockStyle.Top;
            companyPanel.Location = new Point(0, 26);
            companyPanel.Name = "companyPanel";
            companyPanel.Padding = new Padding(15, 7, 15, 0);
            companyPanel.Size = new Size(370, 32);
            companyPanel.TabIndex = 22;
            companyPanel.Resize += panel1_Resize;
            // 
            // companyTextbox
            // 
            companyTextbox.BackColor = Color.FromArgb(240, 237, 227);
            companyTextbox.BorderStyle = BorderStyle.None;
            companyTextbox.Dock = DockStyle.Fill;
            companyTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            companyTextbox.Location = new Point(15, 7);
            companyTextbox.Name = "companyTextbox";
            companyTextbox.PlaceholderText = "Enter Patient Company";
            companyTextbox.Size = new Size(340, 18);
            companyTextbox.TabIndex = 9;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Dock = DockStyle.Top;
            companyLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            companyLabel.ForeColor = Color.FromArgb(36, 49, 34);
            companyLabel.Location = new Point(0, 0);
            companyLabel.Name = "companyLabel";
            companyLabel.Padding = new Padding(0, 2, 0, 5);
            companyLabel.Size = new Size(68, 26);
            companyLabel.TabIndex = 17;
            companyLabel.Text = "Company";
            // 
            // patientDetailsTableLayout
            // 
            patientDetailsTableLayout.AutoSize = true;
            patientDetailsTableLayout.ColumnCount = 3;
            patientDetailsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.66337F));
            patientDetailsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.66337F));
            patientDetailsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6732674F));
            patientDetailsTableLayout.Controls.Add(patientNameInputPanel, 0, 0);
            patientDetailsTableLayout.Controls.Add(csNoInputPanel, 1, 0);
            patientDetailsTableLayout.Controls.Add(dateInputPanel, 2, 0);
            patientDetailsTableLayout.Dock = DockStyle.Top;
            patientDetailsTableLayout.Location = new Point(20, 45);
            patientDetailsTableLayout.Name = "patientDetailsTableLayout";
            patientDetailsTableLayout.RowCount = 1;
            patientDetailsTableLayout.RowStyles.Add(new RowStyle());
            patientDetailsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            patientDetailsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            patientDetailsTableLayout.Size = new Size(751, 64);
            patientDetailsTableLayout.TabIndex = 3;
            // 
            // patientNameInputPanel
            // 
            patientNameInputPanel.AutoSize = true;
            patientNameInputPanel.Controls.Add(patientNamePanel);
            patientNameInputPanel.Controls.Add(patientNameLabel);
            patientNameInputPanel.Dock = DockStyle.Fill;
            patientNameInputPanel.Location = new Point(3, 3);
            patientNameInputPanel.Name = "patientNameInputPanel";
            patientNameInputPanel.Size = new Size(246, 58);
            patientNameInputPanel.TabIndex = 0;
            // 
            // patientNamePanel
            // 
            patientNamePanel.BackColor = Color.FromArgb(240, 237, 227);
            patientNamePanel.Controls.Add(patientNameTextbox);
            patientNamePanel.Dock = DockStyle.Top;
            patientNamePanel.Location = new Point(0, 26);
            patientNamePanel.Name = "patientNamePanel";
            patientNamePanel.Padding = new Padding(15, 7, 15, 0);
            patientNamePanel.Size = new Size(246, 32);
            patientNamePanel.TabIndex = 18;
            patientNamePanel.Resize += panel1_Resize;
            // 
            // patientNameTextbox
            // 
            patientNameTextbox.BackColor = Color.FromArgb(240, 237, 227);
            patientNameTextbox.BorderStyle = BorderStyle.None;
            patientNameTextbox.Dock = DockStyle.Fill;
            patientNameTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patientNameTextbox.Location = new Point(15, 7);
            patientNameTextbox.Name = "patientNameTextbox";
            patientNameTextbox.PlaceholderText = "Enter Patient Name";
            patientNameTextbox.Size = new Size(216, 18);
            patientNameTextbox.TabIndex = 0;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Dock = DockStyle.Top;
            patientNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            patientNameLabel.ForeColor = Color.FromArgb(36, 49, 34);
            patientNameLabel.Location = new Point(0, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Padding = new Padding(0, 2, 0, 5);
            patientNameLabel.Size = new Size(94, 26);
            patientNameLabel.TabIndex = 5;
            patientNameLabel.Text = "Patient Name";
            // 
            // csNoInputPanel
            // 
            csNoInputPanel.AutoSize = true;
            csNoInputPanel.Controls.Add(csNoPanel);
            csNoInputPanel.Controls.Add(csNoLabel);
            csNoInputPanel.Dock = DockStyle.Fill;
            csNoInputPanel.Location = new Point(255, 3);
            csNoInputPanel.Name = "csNoInputPanel";
            csNoInputPanel.Size = new Size(246, 58);
            csNoInputPanel.TabIndex = 1;
            // 
            // csNoPanel
            // 
            csNoPanel.BackColor = Color.FromArgb(240, 237, 227);
            csNoPanel.Controls.Add(csNoTextbox);
            csNoPanel.Dock = DockStyle.Top;
            csNoPanel.Location = new Point(0, 26);
            csNoPanel.Name = "csNoPanel";
            csNoPanel.Padding = new Padding(15, 7, 15, 0);
            csNoPanel.Size = new Size(246, 32);
            csNoPanel.TabIndex = 19;
            csNoPanel.Resize += panel1_Resize;
            // 
            // csNoTextbox
            // 
            csNoTextbox.BackColor = Color.FromArgb(240, 237, 227);
            csNoTextbox.BorderStyle = BorderStyle.None;
            csNoTextbox.Dock = DockStyle.Fill;
            csNoTextbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            csNoTextbox.Location = new Point(15, 7);
            csNoTextbox.Name = "csNoTextbox";
            csNoTextbox.PlaceholderText = "Enter CS No";
            csNoTextbox.Size = new Size(216, 18);
            csNoTextbox.TabIndex = 9;
            // 
            // csNoLabel
            // 
            csNoLabel.AutoSize = true;
            csNoLabel.Dock = DockStyle.Top;
            csNoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            csNoLabel.ForeColor = Color.FromArgb(36, 49, 34);
            csNoLabel.Location = new Point(0, 0);
            csNoLabel.Name = "csNoLabel";
            csNoLabel.Padding = new Padding(0, 2, 0, 5);
            csNoLabel.Size = new Size(49, 26);
            csNoLabel.TabIndex = 12;
            csNoLabel.Text = "CS No";
            // 
            // dateInputPanel
            // 
            dateInputPanel.AutoSize = true;
            dateInputPanel.Controls.Add(datePanel);
            dateInputPanel.Controls.Add(dateLabel);
            dateInputPanel.Dock = DockStyle.Fill;
            dateInputPanel.Location = new Point(507, 3);
            dateInputPanel.Name = "dateInputPanel";
            dateInputPanel.Size = new Size(241, 58);
            dateInputPanel.TabIndex = 2;
            // 
            // datePanel
            // 
            datePanel.BackColor = Color.FromArgb(240, 237, 227);
            datePanel.Controls.Add(dateTimePicker1);
            datePanel.Dock = DockStyle.Top;
            datePanel.Location = new Point(0, 26);
            datePanel.Name = "datePanel";
            datePanel.Padding = new Padding(15, 5, 15, 0);
            datePanel.Size = new Size(241, 32);
            datePanel.TabIndex = 20;
            datePanel.Resize += panel1_Resize;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(240, 237, 227);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(240, 237, 227);
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(15, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Dock = DockStyle.Top;
            dateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.FromArgb(36, 49, 34);
            dateLabel.Location = new Point(0, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Padding = new Padding(0, 2, 0, 5);
            dateLabel.Size = new Size(38, 26);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Date";
            // 
            // topGreenLine
            // 
            topGreenLine.BackColor = Color.FromArgb(148, 177, 114);
            topGreenLine.Dock = DockStyle.Top;
            topGreenLine.Location = new Point(20, 43);
            topGreenLine.Name = "topGreenLine";
            topGreenLine.Size = new Size(751, 2);
            topGreenLine.TabIndex = 1;
            // 
            // patientDetailsLabel
            // 
            patientDetailsLabel.AutoSize = true;
            patientDetailsLabel.Dock = DockStyle.Top;
            patientDetailsLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            patientDetailsLabel.ForeColor = Color.FromArgb(36, 49, 34);
            patientDetailsLabel.Location = new Point(20, 10);
            patientDetailsLabel.Margin = new Padding(0, 3, 3, 5);
            patientDetailsLabel.Name = "patientDetailsLabel";
            patientDetailsLabel.Padding = new Padding(0, 0, 0, 5);
            patientDetailsLabel.Size = new Size(142, 33);
            patientDetailsLabel.TabIndex = 0;
            patientDetailsLabel.Text = "Patient Details";
            // 
            // addProcedureDisabledTooltip
            // 
            addProcedureDisabledTooltip.AutomaticDelay = 10;
            addProcedureDisabledTooltip.AutoPopDelay = 30000;
            addProcedureDisabledTooltip.InitialDelay = 10;
            addProcedureDisabledTooltip.ReshowDelay = 2;
            addProcedureDisabledTooltip.ShowAlways = true;
            addProcedureDisabledTooltip.ToolTipIcon = ToolTipIcon.Warning;
            addProcedureDisabledTooltip.ToolTipTitle = "Action Required";
            // 
            // NewBillingUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 226);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(headerLabel);
            Controls.Add(contentPanel);
            Name = "NewBillingUserControl";
            Padding = new Padding(2);
            Size = new Size(800, 600);
            Load += NewBillingUserControl_Load;
            Paint += contentPanel_Paint;
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            totalPricePanel.ResumeLayout(false);
            totalPricePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            procedureRowsPanel.ResumeLayout(false);
            procedureRowsPanel.PerformLayout();
            procedureListLabelLayout.ResumeLayout(false);
            procedureListLabelLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            personnelInputPanel.ResumeLayout(false);
            personnelInputPanel.PerformLayout();
            personnelPanel.ResumeLayout(false);
            personnelPanel.PerformLayout();
            companyInputPanel.ResumeLayout(false);
            companyInputPanel.PerformLayout();
            companyPanel.ResumeLayout(false);
            companyPanel.PerformLayout();
            patientDetailsTableLayout.ResumeLayout(false);
            patientDetailsTableLayout.PerformLayout();
            patientNameInputPanel.ResumeLayout(false);
            patientNameInputPanel.PerformLayout();
            patientNamePanel.ResumeLayout(false);
            patientNamePanel.PerformLayout();
            csNoInputPanel.ResumeLayout(false);
            csNoInputPanel.PerformLayout();
            csNoPanel.ResumeLayout(false);
            csNoPanel.PerformLayout();
            dateInputPanel.ResumeLayout(false);
            dateInputPanel.PerformLayout();
            datePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Panel contentPanel;
        private Label patientDetailsLabel;
        private Label topGreenLine;
        private Label patientNameLabel;
        private TextBox patientNameTextbox;
        private TextBox csNoTextbox;
        private Label companyLabel;
        private TextBox companyTextbox;
        private Label personnelLabel;
        private Label dateLabel;
        private Label csNoLabel;
        private Panel patientNamePanel;
        private Panel csNoPanel;
        private Panel datePanel;
        private Panel personnelPanel;
        private TextBox personnelTextbox;
        private Panel companyPanel;
        private Label bottomGreenLine;
        private Label proceduresLabel;
        private DateTimePicker dateTimePicker1;
        private Panel procedureRowsPanel;
        private ProcedureListRowUserControl procedureListRowUserControl1;
        private Button addProcedureButton;
        private FlowLayoutPanel buttonPanel;
        private TableLayoutPanel totalPricePanel;
        private Label totalAmount;
        private Label totalAmountLabel;
        private TableLayoutPanel patientDetailsTableLayout;
        private Panel patientNameInputPanel;
        private Panel csNoInputPanel;
        private Panel dateInputPanel;
        private Panel personnelInputPanel;
        private Panel companyInputPanel;
        private Panel paddingPanel;
        private TableLayoutPanel procedureListLabelLayout;
        private Label label1;
        private Label label2;
        private Button saveButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolTip addProcedureDisabledTooltip;
        private Label procedureSelectionPlaceholder;
    }
}
