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

namespace GraphicsEditor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            this.Width = 800; 
            this.Height = 500;
        }

        LinkedList<Shape> listSh = new LinkedList<Shape>();

        private void Main_Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Drawer drawer = new Drawer();
            drawer.SetGraphics(g);
            for (int i = 0; i < listSh.Count; i++)
            {
                drawer.Draw(listSh.ElementAt(i));
            }
        }

        private void AddFigura(Shape shape)
        {
            int coordX = (int)numericUpDown1.Value;
            int coordY = (int)numericUpDown2.Value;
            shape.X = coordX;
            shape.Y = coordY;
            listSh.AddLast(shape);
            Refresh();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            AddFigura(new Triangle());
        }

        private void R_set_Click(object sender, EventArgs e)
        {
            listSh.Clear();
            Refresh();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            AddFigura(new Circle());
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            AddFigura(new Rectangle());
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            AddFigura(new Ellipse());
        }

        private void LineSegment_Click(object sender, EventArgs e)
        {
            AddFigura(new LineSegment());
        }

        private void Trapeze_Click(object sender, EventArgs e)
        {
            AddFigura(new Trapeze());
        }
    }
}
