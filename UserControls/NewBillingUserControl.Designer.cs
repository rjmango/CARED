using System;
using System.Windows.Forms;
using CARED.Services; // Assuming your service interfaces are here

namespace CARED.UserControls
{
    public partial class NewBillingUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        private IProcedureService _procedureService;
        private ITransactionService _transactionService;

        public NewBillingUserControl(IProcedureService procedureService, ITransactionService transactionService)
        {
            _procedureService = procedureService;
            _transactionService = transactionService;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(36, 49, 34);
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(264, 40);
            label1.TabIndex = 1;
            label1.Text = "New Record Entry";
            // 
            // NewBillingUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 226);
            Controls.Add(label1);
            Name = "NewBillingUserControl";
            Size = new Size(800, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
