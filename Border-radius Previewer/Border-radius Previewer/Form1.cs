using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Border_radius_Previewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoundedPanel();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            RoundedPanel();
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, float topLeftX, float topLeftY, float topRightX, float topRightY, float bottomRightX, float bottomRightY, float bottomLeftX, float bottomLeftY)
        {
            GraphicsPath path = new GraphicsPath();
            // Параметры AddArc
            //x Single - Координата x верхнего левого угла прямоугольной области, определяющей многоточие, из которого рисуется дуга.
            //y Single - Координата y верхнего левого угла прямоугольной области, определяющей многоточие, из которого рисуется дуга.
            //width Single - Ширина прямоугольной области, которая определяет многоточие, из которого рисуется дуга.
            //height Single - Высота прямоугольной области, определяющей многоточие, из которого рисуется дуга.
            //startAngle Single - Начальный угол дуги, измеряемый по градусам по часовой стрелке от оси x.
            //sweepAngle Single - Угол между startAngle и концом дуги.

            // Параметры AddLine
            // x1 Int32 - Координата x начальной точки линии.
            // y1 Int32 - Координата y начальной точки линии.
            //x2 Int32 - Координата x конечной точки строки.
            //y2 - Int32 - Координата y конечной точки строки.

            path.AddArc(bounds.X, bounds.Y, topLeftX * 2, topLeftY * 2, 180, 90);
            path.AddLine(bounds.X + topLeftX, bounds.Y, bounds.Right - topRightX, bounds.Y);
            path.AddArc(bounds.Right - topRightX * 2, bounds.Y, topRightX * 2, topRightY * 2, 270, 90);
            path.AddLine(bounds.Right, bounds.Y + topRightY, bounds.Right, bounds.Bottom - bottomRightY);
            path.AddArc(bounds.Right - bottomRightX * 2, bounds.Bottom - bottomRightY * 2, bottomRightX * 2, bottomRightY * 2, 0, 90);
            path.AddLine(bounds.Right - bottomRightX, bounds.Bottom, bounds.X + bottomLeftX, bounds.Bottom);
            path.AddArc(bounds.X, bounds.Bottom - bottomLeftY * 2, bottomLeftX * 2, bottomLeftY * 2, 90, 90);
            path.AddLine(bounds.X, bounds.Bottom - bottomLeftY, bounds.X, bounds.Y + topLeftY);
            path.CloseFigure();
            return path;
        }

        private void RoundedPanel()
        {
            if (Convert.ToInt32(TbTopLeftX.Text) > 0 && Convert.ToInt32(TbTopLeftX.Text) < 100 &&
                Convert.ToInt32(TbTopLeftY.Text) > 0 && Convert.ToInt32(TbTopLeftY.Text) < 100 &&
                Convert.ToInt32(TbTopRightX.Text) > 0 && Convert.ToInt32(TbTopRightX.Text) < 100 &&
                Convert.ToInt32(TbTopRightY.Text) > 0 && Convert.ToInt32(TbTopRightY.Text) < 100 &&
                Convert.ToInt32(TbBottomRightX.Text) > 0 && Convert.ToInt32(TbBottomRightX.Text) < 100 &&
                Convert.ToInt32(TbBottomRightY.Text) > 0 && Convert.ToInt32(TbBottomRightY.Text) < 100 &&
                Convert.ToInt32(TbBottomLeftX.Text) > 0 && Convert.ToInt32(TbBottomLeftX.Text) < 100 &&
                Convert.ToInt32(TbBottomLeftY.Text) > 0 && Convert.ToInt32(TbBottomLeftY.Text) < 100)
            {
                using (Graphics g = MainPanel.CreateGraphics())
                {
                    float topLeftX = float.Parse(TbTopLeftX.Text);
                    float topLeftY = float.Parse(TbTopLeftY.Text);
                    float topRightX = float.Parse(TbTopRightX.Text);
                    float topRightY = float.Parse(TbTopRightY.Text);
                    float bottomRightX = float.Parse(TbBottomRightX.Text);
                    float bottomRightY = float.Parse(TbBottomRightY.Text);
                    float bottomLeftX = float.Parse(TbBottomLeftX.Text);
                    float bottomLeftY = float.Parse(TbBottomLeftY.Text);
                    Rectangle bounds = MainPanel.ClientRectangle;
                    GraphicsPath path = RoundedRectangle(bounds,
                        topLeftX, topLeftY,
                        topRightX, topRightY,
                        bottomRightX, bottomRightY,
                        bottomLeftX, bottomLeftY);
                    Region region = new Region(path);
                    MainPanel.Region = region;
                    g.FillPath(Brushes.Maroon, path);
                    g.DrawPath(Pens.Black, path);
                }
            }
            else
            {
                MessageBox.Show("Incorrect value");
            }
        }

        private void TbTopLeftX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void BtCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TbTopLeftX.Text + ", " + TbTopLeftY.Text + ", " + TbTopRightX.Text + ", " + TbTopRightY.Text + ", " + TbBottomRightX.Text + ", " + TbBottomRightY.Text + ", " + TbBottomLeftX.Text + ", " + TbBottomLeftY.Text);
        }
    }
}
