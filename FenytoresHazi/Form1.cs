using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenytoresHazi
{
    public partial class Form1 : Form
    {
        int x;
        int y;

        double alfa = 45;
        double beta = 0;
        double n1 = 1;
        double n2 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point p1 = new Point(panel1.Width / 2, 0);
            x = p1.X;
            y = p1.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var x = panel1.Width / 2;
            var y = 0;
            var angle = ConvertToRadians(90) - ConvertToRadians(alfa);
            var length = 400;

            // Create pen.
            Pen grayPen = new Pen(Color.Gray, 1);
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            // draw middle line
            Point point1 = new Point(x, y);
            Point point2 = new Point(x, panel1.Height);

            // draw light line1
            Point point3 = new Point(x, panel1.Height);

            var x2 = Convert.ToInt32(Math.Cos(angle) * length);
            var y2 = Convert.ToInt32(Math.Sin(angle) * length);
            Point point4 = new Point(x - x2, y - y2);
            //Point point4 = new Point(0,0);

            // Draw line to screen.
            e.Graphics.DrawLine(grayPen, point1, point2);
            e.Graphics.DrawLine(blackPen, point3, point4);
        }

        private void Calculate(double alfa, double n1, double n2)
        {
            var sinBeta = n1 * Math.Sin(ConvertToRadians(alfa)) / n2;
            beta = Math.Asin(sinBeta);
        }

        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public double ConvertToDegrees(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var x = panel2.Width / 2;
            var y = 0;
            var angle = ConvertToRadians(90) - beta;
            var length = 400;

            // Create pen.
            Pen grayPen = new Pen(Color.Gray, 1);
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            // draw middle line
            Point point1 = new Point(x, y);
            Point point2 = new Point(x, panel2.Height);

            // draw light line1
            Point point3 = new Point(x, y);

            var x2 = Convert.ToInt32(Math.Cos(angle) * length);
            var y2 = Convert.ToInt32(Math.Sin(angle) * length);
            Point point4 = new Point(x + x2, y + y2);

            // Draw line to screen.
            e.Graphics.DrawLine(grayPen, point1, point2);
            e.Graphics.DrawLine(blackPen, point3, point4);
        }

        private void alfaInput_ValueChanged(object sender, EventArgs e)
        {
            updateDrawing();
        }

        private void n1Input_ValueChanged(object sender, EventArgs e)
        {
            updateDrawing();
        }

        private void n2Input_ValueChanged(object sender, EventArgs e)
        {
            updateDrawing();
        }

        private void updateDrawing()
        {
            alfa = Convert.ToDouble(alfaInput.Value);
            n1 = Convert.ToDouble(n1Input.Value);
            n2 = Convert.ToDouble(n2Input.Value);
            Calculate(alfa, n1, n2);
            label4.Text = "beta: " + ConvertToDegrees(beta);
            panel1.Invalidate();
            panel2.Invalidate();
        }
    }
}
