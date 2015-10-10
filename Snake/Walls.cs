using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        private List<Figure> wallsList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallsList = new List<Figure>();
            HorizontalLine downHorizontalLine = new HorizontalLine(0, mapWidth - 1, mapHeight - 1, '+'); // Down horizontal line (xLeft,  xRight,  y,  symbol)
           // downHorizontalLine.DrawFigure();
            wallsList.Add(downHorizontalLine);

            HorizontalLine upHorizontalLine = new HorizontalLine(0, mapWidth - 1 , 0, '+'); // Up horizontal line (xLeft,  xRight,  y,  symbol)
           // upHorizontalLine.DrawFigure();
            wallsList.Add(upHorizontalLine);

            VerticalLine leftVerticalLine = new VerticalLine(0, mapHeight - 1, 0, '+');  // Left vertical line (yUp,  yDown,  x,  symbol)
            //leftVerticalLine.DrawFigure();
            wallsList.Add(leftVerticalLine);

            VerticalLine rightVerticalLine = new VerticalLine(0, mapHeight - 1, mapWidth - 1, '+'); // Right vertical line (yUp,  yDown,  x,  symbol)
           // rightVerticalLine.DrawFigure();
            wallsList.Add(rightVerticalLine);

        }
  

        public void DrawWalls()
        {
            foreach (var wall in wallsList)
            {
                wall.DrawFigure();
            }
        }

    }
}
