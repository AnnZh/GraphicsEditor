using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditor
{
    class Triangle : Shape
    {
        public override GraphicsPath getPath()
        {
            GraphicsPath path = new GraphicsPath();
            Point[] points = new Point[3];

            points[0] = new Point(X + 50, Y);
            points[1] = new Point(X + 100, Y + 100);
            points[2] = new Point(X, Y + 100);
            path.Reset();
            path.AddPolygon(points);

            return path;
        }
    }
}
