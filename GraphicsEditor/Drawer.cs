using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditor
{
    class Drawer
    {
        private Graphics g;
        public void SetGraphics(Graphics g)
        {
            this.g = g;
        }
        public void Draw(Shape shape)
        {

            g.FillPath(Brushes.Black, shape.getPath());
        }
    }
}
