//using System;
//using System.Windows.Forms;
//using CARED.Services;
//using System.Collections.Generic;
//using CARED.Models;

//namespace CARED
//{
//    public partial class mainForm : Form
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            sidePanel = new Panel();
//            button3 = new Button();
//            button2 = new Button();
//            button1 = new Button();
//            sidePanel.SuspendLayout();
//            SuspendLayout();
//            // 
//            // sidePanel
//            // 
//            sidePanel.BackColor = Color.FromArgb(194, 213, 132);
//            sidePanel.Controls.Add(button3);
//            sidePanel.Controls.Add(button2);
//            sidePanel.Controls.Add(button1);
//            sidePanel.Dock = DockStyle.Left;
//            sidePanel.Location = new Point(0, 0);
//            sidePanel.Margin = new Padding(4, 3, 4, 3);
//            sidePanel.Name = "sidePanel";
//            sidePanel.Size = new Size(200, 450);
//            sidePanel.TabIndex = 1;
//            // 
//            // button3
//            // 
//            button3.Location = new Point(50, 310);
//            button3.Name = "button3";
//            button3.Size = new Size(75, 23);
//            button3.TabIndex = 4;
//            button3.Text = "button3";
//            button3.UseVisualStyleBackColor = true;
//            // 
//            // button2
//            // 
//            button2.Location = new Point(50, 232);
//            button2.Name = "button2";
//            button2.Size = new Size(75, 23);
//            button2.TabIndex = 3;
//            button2.Text = "button2";
//            button2.UseVisualStyleBackColor = true;
//            // 
//            // button1
//            // 
//            button1.Location = new Point(50, 155);
//            button1.Name = "button1";
//            button1.Size = new Size(75, 23);
//            button1.TabIndex = 2;
//            button1.Text = "button1";
//            button1.UseVisualStyleBackColor = true;
//            // 
//            // mainForm
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Controls.Add(sidePanel);
//            ForeColor = SystemColors.ControlText;
//            FormBorderStyle = FormBorderStyle.FixedToolWindow;
//            Margin = new Padding(4, 3, 4, 3);
//            MaximizeBox = false;
//            Name = "mainForm";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Form1";
//            sidePanel.ResumeLayout(false);
//            ResumeLayout(false);
//        }

//        #endregion

//        // Inject the Service Layer through the constructor
//        private readonly IServiceProvider _serviceProvider;
//        public mainForm(IServiceProvider serviceProvider)
//        {
//            InitializeComponent();
//            var screen = Screen.PrimaryScreen.WorkingArea;
//            this.Size = new Size((int)(screen.Width * 0.80), (int)(screen.Height * 0.95));
//            _serviceProvider = serviceProvider;
//        }
//        private Panel sidePanel;
//        private Button button3;
//        private Button button2;
//        private Button button1;
//    }
//}

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
        private readonly IServiceProvider _serviceProvider;
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Panel sidePanel;
        private Panel contentPanel;
        private Button btnDashboard;
        private Button btnBilling;
        private Button btnRetrieve;
        private Button activeBtn;

        public mainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            SetupLayoutConfiguration();

            // Start with 
            ShowUserControl<NewBillingUserControl>(btnBilling);
            //ShowUserControl<DashboardUserControl>(btnDashboard);
        }

        private void InitializeComponent()
        {
            sidePanel = new Panel();
            btnDashboard = new Button();
            btnBilling = new Button();
            btnRetrieve = new Button();
            contentPanel = new Panel();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(194, 213, 132);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 450);
            sidePanel.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(75, 23);
            btnDashboard.TabIndex = 0;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(0, 0);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(75, 23);
            btnBilling.TabIndex = 0;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(0, 0);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.WhiteSmoke;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(200, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(600, 450);
            contentPanel.TabIndex = 0;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CARED Management System";
            ResumeLayout(false);
        }

        private void SetupButton(Button btn, string text, int top, Color backColor, Color textColor)
        {
            btn.Text = text;
            btn.Location = new Point(10, top);
            btn.Size = new Size(180, 50); // Initial size, will be adjusted in SetupLayoutConfiguration
            btn.TabIndex = 2;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;

            // Color Settings
            btn.BackColor = backColor;
            btn.ForeColor = textColor;
            btn.FlatAppearance.BorderSize = 0;

            // Interaction Colors
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(154, 173, 92);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(134, 153, 72);

            // Navigation Event
            btn.Click += (s, e) => HandleNavClick(s, e);

            // Add to the sidebar
            this.sidePanel.Controls.Add(btn);
        }

        private void SetupLayoutConfiguration()
        {
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size((int)(screen.Width * 0.80), (int)(screen.Height * 0.95));

            int sidebarWidth = this.ClientSize.Width / 3;
            this.sidePanel.Width = sidebarWidth;

            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Width = sidebarWidth - 40;
                    btn.Left = 20;
                }
            }
        }

        private void HandleNavClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnDashboard) ShowUserControl<DashboardUserControl>(btn);
            else if (btn == btnBilling) ShowUserControl<NewBillingUserControl>(btn);
            else if (btn == btnRetrieve) ShowUserControl<RetrieveRecordsUserControl>(btn);
        }

        // This handles displaying user control and button highlighting
        private void ShowUserControl<T>(Button triggerButton) where T : UserControl
        {
            if (activeBtn != null) activeBtn.BackColor = Color.FromArgb(174, 193, 112);
            activeBtn = triggerButton;
            activeBtn.BackColor = Color.FromArgb(154, 173, 92); // Darker highlight for active tab

            contentPanel.Controls.Clear();
            var control = _serviceProvider.GetRequiredService<T>();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}