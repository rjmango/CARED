using CARED.Services;
using CARED.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace CARED
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private async void deleteButton_Click(object sender, EventArgs e)
        {
            ITransactionService _transactionService = _serviceProvider.GetRequiredService<ITransactionService>();
            // 1. Confirmation Modal
            var result = MessageBox.Show(
                "Are you sure you want to delete ALL transaction records? This cannot be undone.",
                "Permanent Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 2. Call the Service
                    await _transactionService.ClearAllDataAsync();

                    // 3. IMPORTANT: Wipe the Cache
                    // This ensures the Retrieve tab shows an empty list immediately
                    //_cacheService.InvalidateCache();

                    MessageBox.Show("Database cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var currentControl = contentPanel.Controls.Count > 0 ? contentPanel.Controls[0] : null;

                    // 2. Check if it is the RetrieveRecords tab
                    if (currentControl is RetrieveRecordsUserControl retrieveTab)
                    {
                        // 3. Trigger a reload of the empty data
                        // Note: Ensure LoadData is public or internal in RetrieveRecordsUserControl
                        await retrieveTab.LoadData("");
                    }

                    // 4. Refresh current view if needed
                    //HandleNavClick(btnRetrieveRecords, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing database: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
