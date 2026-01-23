using CARED.Data;
using CARED.Services;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace CARED.UserControls
{
    public partial class ExportRecordsUserControl : UserControl
    {
        public ExportRecordsUserControl()
        {
            InitializeComponent();

            // Apply rounded corners after the control is fully loaded
            this.Load += (s, e) =>
            {
                ApplyRoundedCorners(tableLayoutPanel1, 15);
                ApplyRoundedCorners(panel3, 10);
                ApplyRoundedCorners(monthComboBox, 15);
                //ApplyRoundedCorners(insurerComboBox, 15);
                //ApplyRoundedCorners(panel4, 10);
                ApplyRoundedCorners(panel1, 15);
                ApplyRoundedCorners(exportButton, 15);
            };

            // Reapply on resize to maintain rounded corners
            this.Resize += (s, e) =>
            {
                ApplyRoundedCorners(tableLayoutPanel1, 15);
                ApplyRoundedCorners(panel3, 10);
                ApplyRoundedCorners(monthComboBox, 15);
                //ApplyRoundedCorners(insurerComboBox, 15);
                //ApplyRoundedCorners(panel4, 10);
                ApplyRoundedCorners(panel1, 15);
                ApplyRoundedCorners(exportButton, 15);
            };
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            if (control == null) return;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
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
                csSuggestion.Visible = true;
            }
            else
            {
                csSuggestion.Visible = false;
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
                    defaultFileName: textBox6.Text
                );
                MessageBox.Show("Billing Statement exported successfully.");
            }
            else if (ChargeSlipCheckBox.Checked)
            {
                CreateExcelService.GenerateChargeSlips(
                    targetYear: year,
                    targetMonth: month,
                    defaultFileName: textBox6.Text
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insurerLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
