using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace GraphicsEditor
{
    class Rectangle : Shape
    {
        public override GraphicsPath getPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.Reset();
            path.AddRectangle(new RectangleF(X, Y, X + 50, Y + 70));

            return path;
        }
    }
}
