using CARED.Data;
using CARED.Services;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace CARED.UserControls
{
    public partial class ExportRecordsUserControl : UserControl
    {
        public ExportRecordsUserControl()
        {
            InitializeComponent();
        }

        private void DashboardUserControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillingStatementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BillingStatementCheckBox.Checked)
            {
                ChargeSlipCheckBox.Checked = false;
                bsPopup.Visible = true;
            }
            else
            {
                bsPopup.Visible = false;
            }
        }

        private void ChargeSlipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChargeSlipCheckBox.Checked)
            {
                BillingStatementCheckBox.Checked = false;
                bsPopup.Visible = false;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            int month = monthComboBox.SelectedIndex + 1;

            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year (e.g., 2025).");
                return;
            }

            if (month == 0)
            {
                MessageBox.Show("Please select a valid numeric month.");
                return;
            }

            if (BillingStatementCheckBox.Checked)
            {
                CreateExcelService.GenerateBillingStatement(
                    targetYear: year,
                    targetMonth: month,
                    bsName: bsNameTitle.Text,
                    hmo: hmoTitle.Text,
                    defaultFileName: fileNameTextBox.Text
                );
                MessageBox.Show("Billing Statement exported successfully.");
            }
            else if (ChargeSlipCheckBox.Checked)
            {
                CreateExcelService.GenerateChargeSlips(
                    targetYear: year,
                    targetMonth: month,
                    defaultFileName: fileNameTextBox.Text
                );
            }
            else
            {
                MessageBox.Show("Please select an export type.");
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bsPopup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bsNameTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void hmoTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
