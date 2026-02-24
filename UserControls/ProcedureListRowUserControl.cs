using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARED.Utils;
using CARED.Models;

namespace CARED.UserControls
{
    public partial class ProcedureListRowUserControl : UserControl
    {
        public event EventHandler? PriceChanged;
        public event EventHandler? DeleteRequested;

        private Procedure _procedure;
        internal string? SelectedProcedureName;

        public ProcedureListRowUserControl(Procedure procedure)
        {
            InitializeComponent();
            _procedure = procedure;
            SelectedProcedureName = procedure.ProcedureName;
            procedureTextbox.Text = SelectedProcedureName;
            priceTextbox.Text = procedure.Amount.ToString("C");

        }

        private void ProcedureListRowUserControl_Resize(object sender, EventArgs e)
        {
            UIHelper.SetRoundedRegion(this, 5);
        }

        public decimal GetLineTotal()
        {
            // Convert the text back to a number, ignoring the "₱" symbol
            if (decimal.TryParse(priceTextbox.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
            {
                // If you have a Qty box, multiply it here
                // return price * (decimal)numQty.Value;
                return price;
            }
            return 0;
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.ImageIndex = 1;

            deleteButton.FlatAppearance.BorderSize = 1;
            //deleteButton.FlatAppearance.BorderColor = Color.FromArgb(238, 94, 104);
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.ImageIndex = 0;

            deleteButton.FlatAppearance.BorderSize = 0;
        }

        internal int GetSelectedProcedureID()
        {
            return _procedure.ProcedureID;
        }
    }
}
