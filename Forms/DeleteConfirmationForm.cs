using System;
using System.Windows.Forms;
using System.Drawing;

namespace CARED.Forms
{
    public class DeleteConfirmationForm : Form
    {
        private Button btnDelete;
        private Button btnCancel;
        private Label lblMessage;

        public DeleteConfirmationForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblMessage = new Label();
            this.btnDelete = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // Label
            this.lblMessage.Text = "Are you sure you want to delete this record?\nThis action cannot be undone.";
            this.lblMessage.Location = new Point(20, 20);
            this.lblMessage.Size = new Size(300, 50);
            this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            // Cancel Button
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new Point(50, 90);
            this.btnCancel.Size = new Size(100, 35);
            //this.btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            // Delete Button
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new Point(190, 90);
            this.btnDelete.Size = new Size(100, 35);
            this.btnDelete.BackColor = Color.IndianRed;
            this.btnDelete.ForeColor = Color.White;
            //this.btnDelete.Click += (s, e) => {
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //};

            // Form Setup
            this.ClientSize = new Size(350, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Confirm Deletion";
        }
    }
}