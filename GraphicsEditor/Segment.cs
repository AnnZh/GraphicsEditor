using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditor
{
    class LineSegment : Shape
    {
        public override GraphicsPath getPath()
        {
            GraphicsPath path = new GraphicsPath();
            
            path.Reset();
            path.AddPie(X, X, Y, Y, X - 65, Y + 20);

            return path;
        }
    }
}
