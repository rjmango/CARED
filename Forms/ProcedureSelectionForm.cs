using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARED.Models;

namespace CARED.Forms
{
    public partial class ProcedureSelectionForm : Form
    {

        public List<Procedure> SelectedProcedures { get; private set; } = new List<Procedure>();
        public ProcedureSelectionForm(IEnumerable<Procedure> allProcedures, HashSet<string> existingNames)
        {
            InitializeComponent();
            ConfigureListBoxes();
            PopulateLists(allProcedures, existingNames);
        }

        private void ConfigureListBoxes()
        {
            LaboratoryTestsCheckedListBox.DisplayMember = "ProcedureName";
            ImagingServicesCheckedListBox.DisplayMember = "ProcedureName";
            UltrasoundServicesCheckedListBox.DisplayMember = "ProcedureName";
        }

        // Pass the existing names into the method
        private void PopulateLists(IEnumerable<Procedure> allProcedures, HashSet<string> existingNames)
        {
            foreach (var procedure in allProcedures)
            {
                CheckedListBox targetBox = null;

                // Determine which box the procedure belongs to
                switch (procedure.Group)
                {
                    case "LABORATORY TESTS":
                        targetBox = LaboratoryTestsCheckedListBox;
                        break;
                    case "IMAGING SERVICES":
                        targetBox = ImagingServicesCheckedListBox;
                        break;
                    case "ULTRASOUND SERVICES":
                        targetBox = UltrasoundServicesCheckedListBox;
                        break;
                }

                if (targetBox != null)
                {
                    // 1. Add the procedure object
                    int index = targetBox.Items.Add(procedure);

                    // 2. Efficiently check if it should be pre-selected
                    if (existingNames.Contains(procedure.ProcedureName))
                    {
                        targetBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void ConfirmButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 10; // Slightly smaller radius looks better for buttons

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedProcedures.Clear();

            // Helper to collect from all list boxes
            var allBoxes = new[] { LaboratoryTestsCheckedListBox, ImagingServicesCheckedListBox, UltrasoundServicesCheckedListBox };

            foreach (var box in allBoxes)
            {
                foreach (var item in box.CheckedItems)
                {
                    SelectedProcedures.Add((Procedure)item);
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
