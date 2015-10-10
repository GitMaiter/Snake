using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure  // Base class for any figures in field 
    {
        protected List<Point> pointList;
        public void DrawFigure()
        {
            foreach (Point point in pointList)
            {
                point.DrawPoint();
            }
        }
    }
}
