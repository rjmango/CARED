using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace CARED.Utils
{
    public static class UIHelper
    {
        public static void SetRoundedRegion(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                // The diameter must be used for the Arc size
                float diameter = radius * 2;

                path.StartFigure();
                path.AddArc(0, 0, diameter, diameter, 180, 90);
                path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90);
                path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Dispose of the old region to prevent memory leaks
                control.Region?.Dispose();
                control.Region = new Region(path);
            }
        }

        public static void SetRoundedTopOnly(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                float d = radius * 2;
                path.StartFigure();
                // Round Top Left
                path.AddArc(0, 0, d, d, 180, 90);
                // Round Top Right
                path.AddArc(control.Width - d, 0, d, d, 270, 90);
                // Sharp Bottom Right
                path.AddLine(control.Width, control.Height, control.Width, control.Height);
                // Sharp Bottom Left
                path.AddLine(0, control.Height, 0, control.Height);
                path.CloseFigure();

                control.Region?.Dispose();
                control.Region = new Region(path);
            }
        }

        // NEW: Function for Bottom Corners Only
        public static void SetRoundedBottomOnly(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                float d = radius * 2;
                path.StartFigure();
                // Sharp Top Left
                path.AddLine(0, 0, 0, 0);
                // Sharp Top Right
                path.AddLine(control.Width, 0, control.Width, 0);
                // Round Bottom Right
                path.AddArc(control.Width - d, control.Height - d, d, d, 0, 90);
                // Round Bottom Left
                path.AddArc(0, control.Height - d, d, d, 90, 90);
                path.CloseFigure();

                control.Region?.Dispose();
                control.Region = new Region(path);
            }
        }
    }
}
