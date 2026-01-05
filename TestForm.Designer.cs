using System;
using System.Windows.Forms;
using CARED.Services;
using System.Collections.Generic;
using CARED.Models;

namespace CARED
{
    public partial class TestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "TestForm";
        }

        #endregion

        // Inject the Service Layer through the constructor
        private readonly IProcedureService _procedureService;

        public TestForm(IProcedureService procedureService)
        {
            InitializeComponent();
            _procedureService = procedureService;

            this.Load += Load_TestForms;
        }

        private async void Load_TestForms(object? sender, EventArgs e)
        {
            this.Text = "Loading Procedures...";
            await LoadProcedureData();
        }

        private async Task LoadProcedureData()
        {
            try
            {
                List<Procedure> procedures = await _procedureService.GetAllProceduresAsync();
                string procedureList = string.Join("\n", procedures.Take(5).Select(p => $"ID: {p.ProcedureID}, Name: {p.ProcedureName}, Amount: {p.Amount}, Group: {p.Group}, SubGroup: {p.SubGroup}"));
                MessageBox.Show($"Loaded {procedures.Count} procedures.\n\nFirst 5:\n{procedureList}", "Success");
                // Verification Check: If this MessageBox shows 3, your seeding worked!
                MessageBox.Show($"Successfully loaded {procedures.Count} procedures from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Text = "Error loading procedures";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}