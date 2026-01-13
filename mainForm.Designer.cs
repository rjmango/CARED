using System;
using System.Windows.Forms;
using System.Drawing;
using CARED.Services;
using CARED.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace CARED
{
    public partial class mainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button activeBtn;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            btnPrintRecords = new Button();
            btnRetrieveRecords = new Button();
            btnNewRecord = new Button();
            contentPanel = new Panel();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(37, 48, 35);
            sidePanel.Controls.Add(btnPrintRecords);
            sidePanel.Controls.Add(btnRetrieveRecords);
            sidePanel.Controls.Add(btnNewRecord);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 450);
            sidePanel.TabIndex = 1;
            // 
            // btnPrintRecords
            // 
            btnPrintRecords.BackColor = Color.FromArgb(37, 48, 35);
            btnPrintRecords.FlatAppearance.BorderSize = 0;
            btnPrintRecords.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 73, 50);
            btnPrintRecords.FlatStyle = FlatStyle.Flat;
            btnPrintRecords.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintRecords.ForeColor = SystemColors.Window;
            btnPrintRecords.Location = new Point(26, 260);
            btnPrintRecords.Name = "btnPrintRecords";
            btnPrintRecords.Size = new Size(149, 36);
            btnPrintRecords.TabIndex = 0;
            btnPrintRecords.Text = "Export Records";
            btnPrintRecords.UseVisualStyleBackColor = false;
            btnPrintRecords.Click += HandleNavClick;
            // 
            // btnRetrieveRecords
            // 
            btnRetrieveRecords.BackColor = Color.FromArgb(37, 48, 35);
            btnRetrieveRecords.FlatAppearance.BorderSize = 0;
            btnRetrieveRecords.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 73, 50);
            btnRetrieveRecords.FlatStyle = FlatStyle.Flat;
            btnRetrieveRecords.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetrieveRecords.ForeColor = SystemColors.Window;
            btnRetrieveRecords.Location = new Point(26, 190);
            btnRetrieveRecords.Name = "btnRetrieveRecords";
            btnRetrieveRecords.Size = new Size(149, 36);
            btnRetrieveRecords.TabIndex = 0;
            btnRetrieveRecords.Text = "Retrieve Records";
            btnRetrieveRecords.UseVisualStyleBackColor = false;
            btnRetrieveRecords.Click += HandleNavClick;
            // 
            // btnNewRecord
            // 
            btnNewRecord.BackColor = Color.FromArgb(37, 48, 35);
            btnNewRecord.FlatAppearance.BorderSize = 0;
            btnNewRecord.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 73, 50);
            btnNewRecord.FlatStyle = FlatStyle.Flat;
            btnNewRecord.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewRecord.ForeColor = SystemColors.Window;
            btnNewRecord.Location = new Point(26, 120);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(149, 36);
            btnNewRecord.TabIndex = 0;
            btnNewRecord.Text = "New Record";
            btnNewRecord.UseVisualStyleBackColor = false;
            btnNewRecord.Click += HandleNavClick;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(240, 237, 226);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(200, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(600, 450);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void HandleNavClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnPrintRecords) ShowUserControl<ExportRecordsUserControl>(btn);
            else if (btn == btnNewRecord) ShowUserControl<NewBillingUserControl>(btn);
            else if (btn == btnRetrieveRecords) ShowUserControl<RetrieveRecordsUserControl>(btn);
        }

        private void ShowUserControl<T>(Button triggerButton) where T : UserControl
        {
            if (activeBtn != null) activeBtn.BackColor = Color.FromArgb(37, 48, 35);
            activeBtn = triggerButton;
            activeBtn.BackColor = Color.FromArgb(149, 177, 114); // Darker highlight for active tab

            contentPanel.Controls.Clear();
            var control = _serviceProvider.GetRequiredService<T>();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }



        #endregion

        // Inject the Service Layer through the constructor
        private readonly IServiceProvider _serviceProvider;
        public mainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size((int)(screen.Width * 0.80), (int)(screen.Height * 0.95));
            _serviceProvider = serviceProvider;
            // Start with Dashboard
            ShowUserControl<NewBillingUserControl>(btnNewRecord);
        }
        private Panel sidePanel;
        private Button btnNewRecord;
        private Panel contentPanel;
        private Button btnPrintRecords;
        private Button btnRetrieveRecords;
    }
}

//using System;
//using System.Windows.Forms;
//using System.Drawing;
//using CARED.Services;
//using CARED.UserControls;
//using Microsoft.Extensions.DependencyInjection;

//namespace CARED
//{
//    public partial class mainForm : Form
//    {
//        private readonly IServiceProvider _serviceProvider;
//        private System.ComponentModel.IContainer components = null;

//        // Controls
//        private Panel sidePanel;
//        private Panel contentPanel;
//        private Button btnDashboard;
//        private Button btnBilling;
//        private Button btnRetrieve;
//        private Button activeBtn;

//        public mainForm(IServiceProvider serviceProvider)
//        {
//            _serviceProvider = serviceProvider;
//            InitializeComponent();
//            SetupLayoutConfiguration();

//            // Start with Dashboard
//            ShowUserControl<DashboardUserControl>(btnDashboard);
//        }

//        private void InitializeComponent()
//        {
//            sidePanel = new Panel();
//            btnDashboard = new Button();
//            btnBilling = new Button();
//            btnRetrieve = new Button();
//            contentPanel = new Panel();

//            this.sidePanel.SuspendLayout();
//            this.SuspendLayout();

//            // 1. sidePanel (Sidebar)
//            sidePanel.BackColor = Color.FromArgb(194, 213, 132);
//            sidePanel.Dock = DockStyle.Left;
//            sidePanel.Location = new Point(0, 0);
//            sidePanel.Name = "sidePanel";
//            sidePanel.TabIndex = 1;

//            // 2. CALL THE SETUPBUTTON METHOD HERE
//            // This is when the buttons are actually configured with colors and events.
//            Color btnColor = Color.FromArgb(174, 193, 112); // Slightly darker for contrast
//            SetupButton(btnDashboard, "Dashboard", 150, btnColor, Color.Black);
//            SetupButton(btnBilling, "New Record / Billing", 220, btnColor, Color.Black);
//            SetupButton(btnRetrieve, "Retrieve Past Records", 290, btnColor, Color.Black);

//            // 3. contentPanel (The 2/3 area)
//            contentPanel.BackColor = Color.WhiteSmoke;
//            contentPanel.Dock = DockStyle.Fill;
//            contentPanel.Location = new Point(200, 0);
//            contentPanel.Name = "contentPanel";
//            contentPanel.Padding = new Padding(20);
//            contentPanel.TabIndex = 0;

//            // 4. mainForm Configuration
//            this.AutoScaleDimensions = new SizeF(7F, 15F);
//            this.AutoScaleMode = AutoScaleMode.Font;
//            this.ClientSize = new Size(800, 450);
//            this.Controls.Add(contentPanel);
//            this.Controls.Add(sidePanel);
//            this.Name = "mainForm";
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.Text = "CARED Management System";

//            this.sidePanel.ResumeLayout(false);
//            this.ResumeLayout(false);
//        }

//        private void SetupButton(Button btn, string text, int top, Color backColor, Color textColor)
//        {
//            btn.Text = text;
//            btn.Location = new Point(10, top);
//            btn.Size = new Size(180, 50); // Initial size, will be adjusted in SetupLayoutConfiguration
//            btn.TabIndex = 2;
//            btn.FlatStyle = FlatStyle.Flat;
//            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
//            btn.TextAlign = ContentAlignment.MiddleCenter;
//            btn.Cursor = Cursors.Hand;

//            // Color Settings
//            btn.BackColor = backColor;
//            btn.ForeColor = textColor;
//            btn.FlatAppearance.BorderSize = 0;

//            // Interaction Colors
//            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(154, 173, 92);
//            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(134, 153, 72);

//            // Navigation Event
//            btn.Click += (s, e) => HandleNavClick(s, e);

//            // Add to the sidebar
//            this.sidePanel.Controls.Add(btn);
//        }

//        private void SetupLayoutConfiguration()
//        {
//            var screen = Screen.PrimaryScreen.WorkingArea;
//            this.Size = new Size((int)(screen.Width * 0.80), (int)(screen.Height * 0.95));

//            int sidebarWidth = this.ClientSize.Width / 3;
//            this.sidePanel.Width = sidebarWidth;

//            foreach (Control ctrl in sidePanel.Controls)
//            {
//                if (ctrl is Button btn)
//                {
//                    btn.Width = sidebarWidth - 40;
//                    btn.Left = 20;
//                }
//            }
//        }

//        private void HandleNavClick(object sender, EventArgs e)
//        {
//            Button btn = (Button)sender;
//            if (btn == btnDashboard) ShowUserControl<DashboardUserControl>(btn);
//            else if (btn == btnBilling) ShowUserControl<NewBillingUserControl>(btn);
//            else if (btn == btnRetrieve) ShowUserControl<RetrieveRecordsUserControl>(btn);
//        }

//        private void ShowUserControl<T>(Button triggerButton) where T : UserControl
//        {
//            if (activeBtn != null) activeBtn.BackColor = Color.FromArgb(174, 193, 112);
//            activeBtn = triggerButton;
//            activeBtn.BackColor = Color.FromArgb(154, 173, 92); // Darker highlight for active tab

//            contentPanel.Controls.Clear();
//            var control = _serviceProvider.GetRequiredService<T>();
//            control.Dock = DockStyle.Fill;
//            contentPanel.Controls.Add(control);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}