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
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            button2.Click += button2_Click; // Search Button
            textBox1.KeyDown += textBox1_KeyDown; // Allow pressing Enter
            textBox1.TextChanged += textBox1_TextChanged; // Type-as-you-go Search

            SetupDataGridView();
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
            csNoDataGridViewTextBoxColumn.FillWeight = 10;

            // Date: Small-Medium (e.g., 12%)
            dateDataGridViewTextBoxColumn.FillWeight = 12;

            // Name: Medium (e.g., 18%)
            nameDataGridViewTextBoxColumn.FillWeight = 18;

            // Personnel: Medium (e.g., 15%)
            personnelDataGridViewTextBoxColumn.FillWeight = 15;

            // Procedures: Largest (e.g., 45%) - needs the most space for lists
            transactedProceduresDataGridViewTextBoxColumn.FillWeight = 45;
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
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading records: {ex.Message}");
            }
        }

        // Search Button Click
        private async void button2_Click(object? sender, EventArgs e)
        {
            string term = textBox1.Text.Trim();
            await LoadData(term);
        }

        // Allow pressing "Enter" in the textbox
        private async void textBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Stop the 'ding' sound
                string term = textBox1.Text.Trim();
                await LoadData(term);
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

        // --- Empty Event Handlers (Keep these to avoid Designer errors if they are linked) ---    
        private void label1_Click(object sender, EventArgs e) { }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}