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
            headerLabel = new Label();
            contentPanel = new Panel();
            saveButtonPanel = new FlowLayoutPanel();
            saveButton = new Button();
            totalPricePanel = new TableLayoutPanel();
            totalAmount = new Label();
            totalAmountLabel = new Label();
            buttonPanel = new FlowLayoutPanel();
            addProcedureButton = new Button();
            procedureRowsPanel = new Panel();
            procedureListLabelLayout = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            paddingPanel = new Panel();
            bottomGreenLine = new Label();
            proceduresLabel = new Label();
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
            personnelInputPanel = new Panel();
            personnelPanel = new Panel();
            personnelTextbox = new TextBox();
            personnelLabel = new Label();
            companyInputPanel = new Panel();
            companyPanel = new Panel();
            companyTextbox = new TextBox();
            companyLabel = new Label();
            topGreenLine = new Label();
            patientDetailsLabel = new Label();
            contentPanel.SuspendLayout();
            saveButtonPanel.SuspendLayout();
            totalPricePanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            procedureListLabelLayout.SuspendLayout();
            patientDetailsTableLayout.SuspendLayout();
            patientNameInputPanel.SuspendLayout();
            patientNamePanel.SuspendLayout();
            csNoInputPanel.SuspendLayout();
            csNoPanel.SuspendLayout();
            dateInputPanel.SuspendLayout();
            datePanel.SuspendLayout();
            personnelInputPanel.SuspendLayout();
            personnelPanel.SuspendLayout();
            companyInputPanel.SuspendLayout();
            companyPanel.SuspendLayout();
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
            contentPanel.Controls.Add(saveButtonPanel);
            contentPanel.Controls.Add(totalPricePanel);
            contentPanel.Controls.Add(buttonPanel);
            contentPanel.Controls.Add(procedureRowsPanel);
            contentPanel.Controls.Add(procedureListLabelLayout);
            contentPanel.Controls.Add(paddingPanel);
            contentPanel.Controls.Add(bottomGreenLine);
            contentPanel.Controls.Add(proceduresLabel);
            contentPanel.Controls.Add(patientDetailsTableLayout);
            contentPanel.Controls.Add(topGreenLine);
            contentPanel.Controls.Add(patientDetailsLabel);
            contentPanel.Location = new Point(4, 65);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20, 25, 20, 20);
            contentPanel.Size = new Size(791, 530);
            contentPanel.TabIndex = 2;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // saveButtonPanel
            // 
            saveButtonPanel.AutoSize = true;
            saveButtonPanel.Controls.Add(saveButton);
            saveButtonPanel.Dock = DockStyle.Top;
            saveButtonPanel.Location = new Point(20, 531);
            saveButtonPanel.Margin = new Padding(3, 3, 0, 3);
            saveButtonPanel.Name = "saveButtonPanel";
            saveButtonPanel.Padding = new Padding(0, 0, 0, 20);
            saveButtonPanel.RightToLeft = RightToLeft.Yes;
            saveButtonPanel.Size = new Size(734, 92);
            saveButtonPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(149, 176, 115);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(546, 20);
            saveButton.Margin = new Padding(3, 20, 0, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(185, 49);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save Record";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            saveButton.Paint += Button_Paint;
            // 
            // totalPricePanel
            // 
            totalPricePanel.AutoSize = true;
            totalPricePanel.BackColor = Color.FromArgb(36, 48, 34);
            totalPricePanel.ColumnCount = 2;
            totalPricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            totalPricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            totalPricePanel.Controls.Add(totalAmount, 1, 0);
            totalPricePanel.Controls.Add(totalAmountLabel, 0, 0);
            totalPricePanel.Dock = DockStyle.Top;
            totalPricePanel.Location = new Point(20, 474);
            totalPricePanel.Name = "totalPricePanel";
            totalPricePanel.Padding = new Padding(5, 10, 5, 10);
            totalPricePanel.RightToLeft = RightToLeft.No;
            totalPricePanel.RowCount = 1;
            totalPricePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalPricePanel.Size = new Size(734, 57);
            totalPricePanel.TabIndex = 0;
            totalPricePanel.Resize += panel1_Resize;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Dock = DockStyle.Right;
            totalAmount.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmount.ForeColor = Color.White;
            totalAmount.ImageAlign = ContentAlignment.MiddleLeft;
            totalAmount.Location = new Point(636, 10);
            totalAmount.Name = "totalAmount";
            totalAmount.RightToLeft = RightToLeft.Yes;
            totalAmount.Size = new Size(90, 37);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "00.00";
            totalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmountLabel.ForeColor = Color.FromArgb(140, 169, 110);
            totalAmountLabel.Location = new Point(8, 10);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(200, 32);
            totalAmountLabel.TabIndex = 0;
            totalAmountLabel.Text = "TOTAL AMOUNT";
            // 
            // buttonPanel
            // 
            buttonPanel.AutoSize = true;
            buttonPanel.Controls.Add(addProcedureButton);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(20, 419);
            buttonPanel.Margin = new Padding(2, 3, 0, 3);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 8, 0, 8);
            buttonPanel.Size = new Size(734, 55);
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
            addProcedureButton.Location = new Point(0, 11);
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
            procedureRowsPanel.AutoSize = true;
            procedureRowsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            procedureRowsPanel.BackColor = Color.FromArgb(240, 237, 227);
            procedureRowsPanel.Dock = DockStyle.Top;
            procedureRowsPanel.Location = new Point(20, 404);
            procedureRowsPanel.Name = "procedureRowsPanel";
            procedureRowsPanel.Padding = new Padding(5, 0, 5, 15);
            procedureRowsPanel.Size = new Size(734, 15);
            procedureRowsPanel.TabIndex = 28;
            procedureRowsPanel.Resize += procedureRowsPanel_Resize;
            // 
            // procedureListLabelLayout
            // 
            procedureListLabelLayout.BackColor = Color.FromArgb(240, 237, 227);
            procedureListLabelLayout.ColumnCount = 2;
            procedureListLabelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            procedureListLabelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            procedureListLabelLayout.Controls.Add(label2, 1, 0);
            procedureListLabelLayout.Controls.Add(label1, 0, 0);
            procedureListLabelLayout.Dock = DockStyle.Top;
            procedureListLabelLayout.Location = new Point(20, 366);
            procedureListLabelLayout.Name = "procedureListLabelLayout";
            procedureListLabelLayout.RowCount = 1;
            procedureListLabelLayout.RowStyles.Add(new RowStyle());
            procedureListLabelLayout.Size = new Size(734, 38);
            procedureListLabelLayout.TabIndex = 0;
            procedureListLabelLayout.Resize += procedureListLabelLayout_Resize;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(36, 49, 34);
            label2.Location = new Point(406, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 10, 0, 0);
            label2.Size = new Size(53, 38);
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
            label1.Padding = new Padding(12, 10, 0, 0);
            label1.Size = new Size(92, 38);
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
            paddingPanel.Location = new Point(20, 356);
            paddingPanel.Name = "paddingPanel";
            paddingPanel.Padding = new Padding(0, 10, 0, 0);
            paddingPanel.Size = new Size(734, 10);
            paddingPanel.TabIndex = 29;
            // 
            // bottomGreenLine
            // 
            bottomGreenLine.BackColor = Color.FromArgb(148, 177, 114);
            bottomGreenLine.Dock = DockStyle.Top;
            bottomGreenLine.Location = new Point(20, 354);
            bottomGreenLine.Name = "bottomGreenLine";
            bottomGreenLine.Size = new Size(734, 2);
            bottomGreenLine.TabIndex = 24;
            // 
            // proceduresLabel
            // 
            proceduresLabel.AutoSize = true;
            proceduresLabel.Dock = DockStyle.Top;
            proceduresLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            proceduresLabel.ForeColor = Color.FromArgb(36, 49, 34);
            proceduresLabel.Location = new Point(20, 296);
            proceduresLabel.Margin = new Padding(0, 3, 3, 5);
            proceduresLabel.Name = "proceduresLabel";
            proceduresLabel.Padding = new Padding(0, 20, 0, 10);
            proceduresLabel.Size = new Size(114, 58);
            proceduresLabel.TabIndex = 23;
            proceduresLabel.Text = "Procedures";
            // 
            // patientDetailsTableLayout
            // 
            patientDetailsTableLayout.AutoSize = true;
            patientDetailsTableLayout.ColumnCount = 2;
            patientDetailsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            patientDetailsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            patientDetailsTableLayout.Controls.Add(patientNameInputPanel, 0, 0);
            patientDetailsTableLayout.Controls.Add(csNoInputPanel, 1, 0);
            patientDetailsTableLayout.Controls.Add(dateInputPanel, 0, 1);
            patientDetailsTableLayout.Controls.Add(personnelInputPanel, 1, 1);
            patientDetailsTableLayout.Controls.Add(companyInputPanel, 0, 2);
            patientDetailsTableLayout.Dock = DockStyle.Top;
            patientDetailsTableLayout.Location = new Point(20, 65);
            patientDetailsTableLayout.Name = "patientDetailsTableLayout";
            patientDetailsTableLayout.RowCount = 3;
            patientDetailsTableLayout.RowStyles.Add(new RowStyle());
            patientDetailsTableLayout.RowStyles.Add(new RowStyle());
            patientDetailsTableLayout.RowStyles.Add(new RowStyle());
            patientDetailsTableLayout.Size = new Size(734, 231);
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
            patientNameInputPanel.Size = new Size(361, 71);
            patientNameInputPanel.TabIndex = 0;
            // 
            // patientNamePanel
            // 
            patientNamePanel.BackColor = Color.FromArgb(240, 237, 227);
            patientNamePanel.Controls.Add(patientNameTextbox);
            patientNamePanel.Dock = DockStyle.Top;
            patientNamePanel.Location = new Point(0, 35);
            patientNamePanel.Name = "patientNamePanel";
            patientNamePanel.Padding = new Padding(15, 7, 15, 0);
            patientNamePanel.Size = new Size(361, 36);
            patientNamePanel.TabIndex = 18;
            patientNamePanel.Resize += panel1_Resize;
            // 
            // patientNameTextbox
            // 
            patientNameTextbox.BackColor = Color.FromArgb(240, 237, 227);
            patientNameTextbox.BorderStyle = BorderStyle.None;
            patientNameTextbox.Dock = DockStyle.Fill;
            patientNameTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            patientNameTextbox.Location = new Point(15, 7);
            patientNameTextbox.Name = "patientNameTextbox";
            patientNameTextbox.PlaceholderText = "Enter Patient Name";
            patientNameTextbox.Size = new Size(331, 22);
            patientNameTextbox.TabIndex = 0;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Dock = DockStyle.Top;
            patientNameLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            patientNameLabel.ForeColor = Color.FromArgb(36, 49, 34);
            patientNameLabel.Location = new Point(0, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Padding = new Padding(0, 10, 0, 5);
            patientNameLabel.Size = new Size(102, 35);
            patientNameLabel.TabIndex = 5;
            patientNameLabel.Text = "Patient Name";
            // 
            // csNoInputPanel
            // 
            csNoInputPanel.AutoSize = true;
            csNoInputPanel.Controls.Add(csNoPanel);
            csNoInputPanel.Controls.Add(csNoLabel);
            csNoInputPanel.Dock = DockStyle.Fill;
            csNoInputPanel.Location = new Point(370, 3);
            csNoInputPanel.Name = "csNoInputPanel";
            csNoInputPanel.Size = new Size(361, 71);
            csNoInputPanel.TabIndex = 1;
            // 
            // csNoPanel
            // 
            csNoPanel.BackColor = Color.FromArgb(240, 237, 227);
            csNoPanel.Controls.Add(csNoTextbox);
            csNoPanel.Dock = DockStyle.Top;
            csNoPanel.Location = new Point(0, 35);
            csNoPanel.Name = "csNoPanel";
            csNoPanel.Padding = new Padding(15, 7, 15, 0);
            csNoPanel.Size = new Size(361, 36);
            csNoPanel.TabIndex = 19;
            csNoPanel.Resize += panel1_Resize;
            // 
            // csNoTextbox
            // 
            csNoTextbox.BackColor = Color.FromArgb(240, 237, 227);
            csNoTextbox.BorderStyle = BorderStyle.None;
            csNoTextbox.Dock = DockStyle.Fill;
            csNoTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csNoTextbox.Location = new Point(15, 7);
            csNoTextbox.Name = "csNoTextbox";
            csNoTextbox.PlaceholderText = "Enter cs No";
            csNoTextbox.Size = new Size(331, 22);
            csNoTextbox.TabIndex = 9;
            // 
            // csNoLabel
            // 
            csNoLabel.AutoSize = true;
            csNoLabel.Dock = DockStyle.Top;
            csNoLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            csNoLabel.ForeColor = Color.FromArgb(36, 49, 34);
            csNoLabel.Location = new Point(0, 0);
            csNoLabel.Name = "csNoLabel";
            csNoLabel.Padding = new Padding(0, 10, 0, 5);
            csNoLabel.Size = new Size(51, 35);
            csNoLabel.TabIndex = 12;
            csNoLabel.Text = "CS No";
            // 
            // dateInputPanel
            // 
            dateInputPanel.AutoSize = true;
            dateInputPanel.Controls.Add(datePanel);
            dateInputPanel.Controls.Add(dateLabel);
            dateInputPanel.Dock = DockStyle.Fill;
            dateInputPanel.Location = new Point(3, 80);
            dateInputPanel.Name = "dateInputPanel";
            dateInputPanel.Size = new Size(361, 71);
            dateInputPanel.TabIndex = 2;
            // 
            // datePanel
            // 
            datePanel.BackColor = Color.FromArgb(240, 237, 227);
            datePanel.Controls.Add(dateTimePicker1);
            datePanel.Dock = DockStyle.Top;
            datePanel.Location = new Point(0, 35);
            datePanel.Name = "datePanel";
            datePanel.Padding = new Padding(15, 7, 15, 0);
            datePanel.Size = new Size(361, 36);
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
            dateTimePicker1.Location = new Point(15, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(331, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Dock = DockStyle.Top;
            dateLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.FromArgb(36, 49, 34);
            dateLabel.Location = new Point(0, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Padding = new Padding(0, 10, 0, 5);
            dateLabel.Size = new Size(41, 35);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Date";
            // 
            // personnelInputPanel
            // 
            personnelInputPanel.AutoSize = true;
            personnelInputPanel.Controls.Add(personnelPanel);
            personnelInputPanel.Controls.Add(personnelLabel);
            personnelInputPanel.Dock = DockStyle.Fill;
            personnelInputPanel.Location = new Point(370, 80);
            personnelInputPanel.Name = "personnelInputPanel";
            personnelInputPanel.Size = new Size(361, 71);
            personnelInputPanel.TabIndex = 3;
            // 
            // personnelPanel
            // 
            personnelPanel.BackColor = Color.FromArgb(240, 237, 227);
            personnelPanel.Controls.Add(personnelTextbox);
            personnelPanel.Dock = DockStyle.Top;
            personnelPanel.Location = new Point(0, 35);
            personnelPanel.Name = "personnelPanel";
            personnelPanel.Padding = new Padding(15, 7, 15, 0);
            personnelPanel.Size = new Size(361, 36);
            personnelPanel.TabIndex = 21;
            personnelPanel.Resize += panel1_Resize;
            // 
            // personnelTextbox
            // 
            personnelTextbox.BackColor = Color.FromArgb(240, 237, 227);
            personnelTextbox.BorderStyle = BorderStyle.None;
            personnelTextbox.Dock = DockStyle.Fill;
            personnelTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personnelTextbox.Location = new Point(15, 7);
            personnelTextbox.Name = "personnelTextbox";
            personnelTextbox.PlaceholderText = "Accomodated by";
            personnelTextbox.Size = new Size(331, 22);
            personnelTextbox.TabIndex = 9;
            personnelTextbox.Leave += personnelTextbox_Leave;
            // 
            // personnelLabel
            // 
            personnelLabel.AutoSize = true;
            personnelLabel.Dock = DockStyle.Top;
            personnelLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            personnelLabel.ForeColor = Color.FromArgb(36, 49, 34);
            personnelLabel.Location = new Point(0, 0);
            personnelLabel.Name = "personnelLabel";
            personnelLabel.Padding = new Padding(0, 10, 0, 5);
            personnelLabel.Size = new Size(146, 35);
            personnelLabel.TabIndex = 14;
            personnelLabel.Text = "Personnel In-charge";
            // 
            // companyInputPanel
            // 
            companyInputPanel.AutoSize = true;
            companyInputPanel.Controls.Add(companyPanel);
            companyInputPanel.Controls.Add(companyLabel);
            companyInputPanel.Dock = DockStyle.Fill;
            companyInputPanel.Location = new Point(3, 157);
            companyInputPanel.Name = "companyInputPanel";
            companyInputPanel.Size = new Size(361, 71);
            companyInputPanel.TabIndex = 4;
            // 
            // companyPanel
            // 
            companyPanel.BackColor = Color.FromArgb(240, 237, 227);
            companyPanel.Controls.Add(companyTextbox);
            companyPanel.Dock = DockStyle.Top;
            companyPanel.Location = new Point(0, 35);
            companyPanel.Name = "companyPanel";
            companyPanel.Padding = new Padding(15, 7, 15, 0);
            companyPanel.Size = new Size(361, 36);
            companyPanel.TabIndex = 22;
            companyPanel.Resize += panel1_Resize;
            // 
            // companyTextbox
            // 
            companyTextbox.BackColor = Color.FromArgb(240, 237, 227);
            companyTextbox.BorderStyle = BorderStyle.None;
            companyTextbox.Dock = DockStyle.Fill;
            companyTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            companyTextbox.Location = new Point(15, 7);
            companyTextbox.Name = "companyTextbox";
            companyTextbox.PlaceholderText = "Enter Patient Company";
            companyTextbox.Size = new Size(331, 22);
            companyTextbox.TabIndex = 9;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Dock = DockStyle.Top;
            companyLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            companyLabel.ForeColor = Color.FromArgb(36, 49, 34);
            companyLabel.Location = new Point(0, 0);
            companyLabel.Name = "companyLabel";
            companyLabel.Padding = new Padding(0, 10, 0, 5);
            companyLabel.Size = new Size(74, 35);
            companyLabel.TabIndex = 17;
            companyLabel.Text = "Company";
            // 
            // topGreenLine
            // 
            topGreenLine.BackColor = Color.FromArgb(148, 177, 114);
            topGreenLine.Dock = DockStyle.Top;
            topGreenLine.Location = new Point(20, 63);
            topGreenLine.Name = "topGreenLine";
            topGreenLine.Size = new Size(734, 2);
            topGreenLine.TabIndex = 1;
            // 
            // patientDetailsLabel
            // 
            patientDetailsLabel.AutoSize = true;
            patientDetailsLabel.Dock = DockStyle.Top;
            patientDetailsLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            patientDetailsLabel.ForeColor = Color.FromArgb(36, 49, 34);
            patientDetailsLabel.Location = new Point(20, 25);
            patientDetailsLabel.Margin = new Padding(0, 3, 3, 5);
            patientDetailsLabel.Name = "patientDetailsLabel";
            patientDetailsLabel.Padding = new Padding(0, 0, 0, 10);
            patientDetailsLabel.Size = new Size(142, 38);
            patientDetailsLabel.TabIndex = 0;
            patientDetailsLabel.Text = "Patient Details";
            // 
            // NewBillingUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 226);
            Controls.Add(headerLabel);
            Controls.Add(contentPanel);
            Name = "NewBillingUserControl";
            Padding = new Padding(2);
            Size = new Size(800, 600);
            Load += NewBillingUserControl_Load;
            Paint += contentPanel_Paint;
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            saveButtonPanel.ResumeLayout(false);
            totalPricePanel.ResumeLayout(false);
            totalPricePanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            procedureListLabelLayout.ResumeLayout(false);
            procedureListLabelLayout.PerformLayout();
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
            personnelInputPanel.ResumeLayout(false);
            personnelInputPanel.PerformLayout();
            personnelPanel.ResumeLayout(false);
            personnelPanel.PerformLayout();
            companyInputPanel.ResumeLayout(false);
            companyInputPanel.PerformLayout();
            companyPanel.ResumeLayout(false);
            companyPanel.PerformLayout();
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
        private FlowLayoutPanel saveButtonPanel;
        private Button saveButton;
    }
}
