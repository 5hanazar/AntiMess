using System.Drawing;
using System.Windows.Forms;

namespace AntiMess
{
    class MyPanel : Panel
    {
        public MyPanel()
        {
            ResizeRedraw = true;
            DoubleBuffered = true;
            BackColor = Color.WhiteSmoke;
            Margin = new Padding(3, 3, 3, 8);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, DisplayRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
