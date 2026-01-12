using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace CARED.UserControls // Make sure this matches your namespace
{
    public class RoundedPanel : Panel
    {
        // Fields
        private int cornerRadius = 20;
        private Color borderColor = Color.DimGray;
        private int borderSize = 2;

        // Properties
        [Category("Appearance")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                this.Invalidate(); // Redraw control
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        // Constructor
        public RoundedPanel()
        {
            this.DoubleBuffered = true; // Prevents flickering
            this.BackColor = Color.White;
            this.Padding = new Padding(10); // Default padding
        }

        // Paint Event
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectBorder = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            RectangleF rectBackground = new RectangleF(1, 1, this.Width - 2, this.Height - 2);

            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, cornerRadius))
            using (GraphicsPath pathBackground = GetRoundedPath(rectBackground, cornerRadius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush brushBackground = new SolidBrush(this.BackColor))
            {
                // Draw Background
                e.Graphics.FillPath(brushBackground, pathBackground);
                // Draw Border
                e.Graphics.DrawPath(penBorder, pathBorder);

                // Clip Region (Important for DataGridView to not overflow corners)
                this.Region = new Region(pathBorder);
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}