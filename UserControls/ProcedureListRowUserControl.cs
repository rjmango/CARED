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
        private void OnPriceChanged()
        {
            PriceChanged?.Invoke(this, EventArgs.Empty);
        }
        public ProcedureListRowUserControl(List<Procedure> procedures)
        {
            InitializeComponent();

            procedureDropdown.MouseWheel += preventScrollWhenDropdownClosed;

            procedureDropdown.DataSource = procedures;
            procedureDropdown.DisplayMember = "ProcedureName";
            procedureDropdown.ValueMember = "ProcedureID";
            procedureDropdown.SelectedIndex = -1; // Default to empty
            procedureDropdown.Text = "Select Procedure";

        }

        public void preventScrollWhenDropdownClosed(object? sender, MouseEventArgs e)
        {
            if (sender is ComboBox comboBox && !comboBox.DroppedDown)
            {
                ((HandledMouseEventArgs)e).Handled = true;
            }
        }

        private void ProcedureListRowUserControl_Resize(object sender, EventArgs e)
        {
            UIHelper.SetRoundedRegion(this, 5);
        }

        private void procedureDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (procedureDropdown.SelectedItem is Procedure selected)
            {
                if (selected.ProcedureID == -1)
                {
                    procedureDropdown.SelectedIndex = -1;
                    priceTextbox.Text = 0.ToString("C2");
                    priceTextbox.ForeColor = Color.Gray;
                }
                else
                {
                    priceTextbox.Text = selected.Amount.ToString("C2");
                    priceTextbox.ForeColor = SystemColors.WindowText;
                }
                OnPriceChanged();

            }
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

        public int GetSelectedProcedureID()
        {
            if (procedureDropdown.SelectedItem is Procedure selected)
            {
                return selected.ProcedureID;
            }
            return 0; // or throw an exception if preferred
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
