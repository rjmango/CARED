using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARED.Services;
using CARED.Models;
using CARED.Forms; 

namespace CARED.UserControls
{
    public partial class RetrieveRecordsUserControl : UserControl
    {
        // 1. Add a field to hold the service
        private readonly ITransactionService? _transactionService;

        // 2. Add a parameterless constructor for the Visual Studio Designer to work
        public RetrieveRecordsUserControl()
        {
            InitializeComponent();
        }

        // 3. Add the main constructor that accepts the service (Dependency Injection)
        public RetrieveRecordsUserControl(ITransactionService transactionService) : this()
        {
            _transactionService = transactionService;

            // Wire up the event manually here to be safe
            textBox1.TextChanged += textBox1_TextChanged; // Type-as-you-go Search
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // *** NEW: Add Double Click Event ***
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            SetupDataGridView();

            // *** CALL THE STYLING METHOD HERE ***
            ApplyModernStyle();
        }
        private void SetupDataGridView()
        {
            // --- Column Weights ---
            // Make the columns fill the entire width of the grid
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Define the "weight" (percentage) for each column.
            // These numbers don't strictly have to add up to 100, 
            // but thinking in percentages makes it easier to design.

            // CS No: Small (e.g., 10%)
            csNoDataGridViewTextBoxColumn.FillWeight = 13;

            // Date: Small-Medium (e.g., 12%)
            dateDataGridViewTextBoxColumn.FillWeight = 12;

            // Name: Medium (e.g., 18%)
            nameDataGridViewTextBoxColumn.FillWeight = 15;

            // Personnel: Medium (e.g., 15%)
            personnelDataGridViewTextBoxColumn.FillWeight = 15;

            // Procedures: Largest (e.g., 45%) - needs the most space for lists
            transactedProceduresDataGridViewTextBoxColumn.FillWeight = 25;

            // 1. Enable text wrapping for the Procedure column so long lists drop to the next line
            transactedProceduresDataGridViewTextBoxColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 2. Tell the grid to automatically adjust row height to fit the wrapped text
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // *** ADDING EDIT ICON COLUMN ***
            if (!dataGridView1.Columns.Contains("EditAction"))
            {
                var editIcon = new DataGridViewImageColumn();
                editIcon.Name = "EditAction";
                editIcon.HeaderText = ""; // Empty header looks cleaner for icons
                // Ensure you have 'edit.png' in Resources
                editIcon.Image = Properties.Resources.edit;

                // FIXED SIZE SETTINGS:
                // 'Normal' keeps original image size (24px etc) regardless of row height
                editIcon.ImageLayout = DataGridViewImageCellLayout.Normal;

                // Width just enough for the icon
                editIcon.Width = 50;
                editIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Lock width

                // Center the icon in the middle of the cell
                editIcon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add(editIcon);
            }

            // *** ADDING DELETE ICON COLUMN ***
            if (!dataGridView1.Columns.Contains("DeleteAction"))
            {
                var delIcon = new DataGridViewImageColumn();
                delIcon.Name = "DeleteAction";
                delIcon.HeaderText = "";
                // Ensure you have 'delete.png' in Resources
                delIcon.Image = Properties.Resources.delete;

                // FIXED SIZE SETTINGS:
                delIcon.ImageLayout = DataGridViewImageCellLayout.Normal;
                delIcon.Width = 50;
                delIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                delIcon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add(delIcon);
            }
        }
        private async void RetrieveRecordsUserControl_Load(object sender, EventArgs e)
        {
            if (_transactionService != null)
            {
                // Load all records initially (empty search term)
                await LoadData("");
            }
        }
        private async Task LoadData(string searchTerm)
        {
            try
            {
                var transactions = await _transactionService!.SearchTransactionsAsync(searchTerm);
                transactionBindingSource.DataSource = transactions;
                // Important: Reset bindings to ensure grid refreshes visual state
                transactionBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading records: {ex.Message}");
            }
        }
        // *** HANDLE BUTTON CLICKS ***
        private async void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header
            if (e.RowIndex < 0) return;

            // 1. EDIT BUTTON CLICKED
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // Get the bound object for this row
                var transaction = transactionBindingSource.List[e.RowIndex] as Transaction;

                if (transaction != null)
                {
                    // Open the Edit Modal
                    using (var editForm = new EditTransactionForm(transaction))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Call Service to Update
                                await _transactionService!.UpdateTransaction(editForm.UpdatedTransaction, editForm.GetProcedureIds());

                                // Refresh Grid
                                await LoadData(textBox1.Text);
                                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            // 2. DELETE BUTTON CLICKED
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                var transaction = transactionBindingSource.List[e.RowIndex] as Transaction;

                if (transaction != null)
                {
                    // Open the Delete Confirmation Modal
                    using (var deleteForm = new DeleteConfirmationForm())
                    {
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Call Service to Delete
                                await _transactionService!.DeleteTransaction(transaction.TransactionID);

                                // Refresh Grid
                                await LoadData(textBox1.Text);
                                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
        private async void textBox1_TextChanged(object? sender, EventArgs e)
        {
            // Search immediately as the user types
            string term = textBox1.Text.Trim();
            await LoadData(term);
        }

        // 6. Handle the CellFormatting event to display Procedure Names instead of "System.Collection..."
        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the "TransactedProcedures" column
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TransactedProcedures" && e.Value != null)
            {
                // Retrieve the list of TransactedProcedure objects
                var procedures = e.Value as ICollection<TransactedProcedure>;

                if (procedures != null && procedures.Count > 0)
                {
                    // Extract the procedure names and join them with commas
                    // We use the null-conditional operator (?) just in case a procedure is missing
                    var procedureNames = procedures
                        .Select(p => p.Procedure?.ProcedureName)
                        .Where(name => !string.IsNullOrEmpty(name));

                    e.Value = string.Join(", ", procedureNames);
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "No Procedures";
                    e.FormattingApplied = true;
                }
            }
        }

        // *** NEW METHOD: Handle Double Click to Show Charge Slip ***
        private void dataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks (RowIndex -1)
            if (e.RowIndex < 0) return;

            // Get the transaction object
            var transaction = transactionBindingSource.List[e.RowIndex] as Transaction;

            if (transaction != null)
            {
                // Open the Charge Slip Form
                using (var slipForm = new ChargeSlipForm(transaction))
                {
                    slipForm.ShowDialog();
                }
            }
        }
        private void ApplyModernStyle()
        {
            // --- 1. STYLE THE SEARCH BAR (Pill Shape) ---

            // Create the container panel
            RoundedPanel searchPanel = new RoundedPanel();
            searchPanel.BackColor = Color.White;
            searchPanel.BorderColor = Color.Silver;
            searchPanel.BorderSize = 1;

            // Match the location/anchors of the original TextBox
            searchPanel.Location = textBox1.Location;
            searchPanel.Width = textBox1.Width;
            searchPanel.Height = textBox1.Height + 14; // Add height for padding (Pill look)
            searchPanel.Anchor = textBox1.Anchor;
            searchPanel.CornerRadius = searchPanel.Height; // Fully rounded ends (Pill)
                                                           
            // A. Create the Search Icon
            PictureBox iconSearch = new PictureBox();
            // Ensure you have added 'search.png' to your Resources
            iconSearch.Image = Properties.Resources.search;
            iconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            iconSearch.Size = new Size(20, 20); // standard icon size
            // Left-most position (10px padding) and Centered Vertically
            iconSearch.Location = new Point(10, (searchPanel.Height - 20) / 2);
            iconSearch.BackColor = Color.Transparent;

            // Move the TextBox inside the Panel
            this.Controls.Add(searchPanel);       // Add panel to form
            searchPanel.Controls.Add(iconSearch);
            textBox1.Parent = searchPanel;        // Move textbox into panel

            // Adjust TextBox look to fit inside
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(iconSearch.Right + 5, 7); // 5px gap
            textBox1.Width = searchPanel.Width - 40; // Adjust width to fill rest of pill
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Stretch with panel


            // --- 2. STYLE THE DATA GRID (Rounded Rectangle) ---

            // A. Basic Setup
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None; // Clean look without the 3D inset border

            // B. Fonts & Spacing (Larger and more breathable)
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridView1.RowTemplate.Height = 45; // Significantly taller rows
            dataGridView1.ColumnHeadersHeight = 50;

            // C. Minimal Borders
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Horizontal lines only
            dataGridView1.GridColor = Color.FromArgb(240, 240, 240); // Very faint gray
            dataGridView1.RowHeadersVisible = false; // Hide the left selector column
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // D. Colors (Soft & Clean)
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // Clean white header
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            // Soft Blue selection instead of harsh dark blue
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        // --- Empty Event Handlers (Keep these to avoid Designer errors if they are linked) ---    
        private void label1_Click(object sender, EventArgs e) { }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e) { }

    }
}