using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditor
{
    class Ellipse : Shape
    {
        public override GraphicsPath getPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.Reset();
            path.AddEllipse(X, Y, X + 50, Y - 50);

            return path;
        }

    }
}
