using System.Media;
using System.Globalization;
using System.IO;
using CARED.Services;

namespace CARED
{
    public partial class printForm : Form
    {
        //private readonly IProcedureService _procedureService;
        private readonly CreateExcelSheetService _billingStatement;

        public printForm(IProcedureService procedureService, CreateExcelSheetService billingStatement)
        {
            InitializeComponent();
            _procedure_service = procedureService;
            _billingStatement = billingStatement;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ////// Attempt to parse int values from textBox1 and comboBox1
            //if (!int.TryParse(textBox1.Text, out var year))
            //{
            //    MessageBox.Show("Invalid year. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Convert month name (e.g., "January") to its corresponding integer (1-12)
            //var monthText = comboBox1.Text?.Trim();
            //if (string.IsNullOrEmpty(monthText))
            //{
            //    MessageBox.Show("Invalid month. Please select a valid month.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (!DateTime.TryParseExact(monthText, new[] { "MMMM", "MMM" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedMonth))
            //{
            //    MessageBox.Show("Invalid month. Please select a valid month.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var month = parsedMonth.Month;

            ///*try
            //{
            //    using var stream = await _billingStatement.CreateBillingStatementFileAsync(year, month);

            //    using var sfd = new SaveFileDialog();
            //    sfd.Filter = "Excel Workbook|*.xlsx";
            //    sfd.FileName = $"Billing_{year}_{month}.xlsx";

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        using var fs = File.Create(sfd.FileName);
            //        await stream.CopyToAsync(fs);
            //        MessageBox.Show("Billing statement saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Failed to create billing statement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //*/

            ////inside button1_Click after computing year and month
            //try
            //{
            //    var defaultPath = Path.Combine(
            //        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            //        $"Billing_{year}_{month}.xlsx");

            //    var savedPath = await _billingStatement.CreateBillingStatementFileAsync(year, month, defaultPath);

            //    //MessageBox.Show($"Billing statement saved to: {savedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Failed to create billing statement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BillingStatementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BillingStatementCheckBox.Checked)
            {
                ChargeSlipCheckBox.Checked = false;
            }

        }

        private void ChargeSlipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChargeSlipCheckBox.Checked)
            {
                BillingStatementCheckBox.Checked = false;
            }

        }

        private void insurerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
