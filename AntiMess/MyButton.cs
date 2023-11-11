using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AntiMess
{
    public class MyButton : Button
    {
        private Color topColor = Color.White;
        private Color bottomColor = Color.Silver;
        [Category("Button Colors")]
        public Color TopColor
        {
            get
            {
                return topColor;
            }
            set
            {
                topColor = value;
                Invalidate();
            }
        }
        [Category("Button Colors")]
        public Color BottomColor
        {
            get
            {
                return bottomColor;
            }
            set
            {
                bottomColor = value;
                Invalidate();
            }
        }

        private int down = 0;
        public MyButton()
        {
            Font = new Font("Arial", 12F, FontStyle.Bold);
            ForeColor = Color.DimGray;
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 3, 4, 3);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), new Rectangle(0, 0, Width, Height));
            var radius = 8;
            var rect = new Rectangle(0, down, Width, Height - 4);
            var brush = new LinearGradientBrush(rect, topColor, topColor, 90F);
            if (Focused)
            {
                var color = ChangeColorBrightness(bottomColor, 0.9F);
                var cblend = new ColorBlend(3);
                cblend.Colors = new Color[3] { Color.White, color, color };
                cblend.Positions = new float[3] { 0f, 0.2f, 1f };
                brush.InterpolationColors = cblend;
            }
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillPath(new SolidBrush(bottomColor), RoundedRect(new Rectangle(0, 8, Width, Height - 8), radius));
            pevent.Graphics.FillPath(brush, RoundedRect(rect, radius));
            var s = rect.Height - 8;
            if (Image != null) pevent.Graphics.DrawImage(Image, (rect.Width - s) / 2, 4 + down, s, s);
            var format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2, (Height / 2) + down, format);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            down = 1;
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            down = 0;
            base.OnMouseUp(mevent);
        }
        private Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
