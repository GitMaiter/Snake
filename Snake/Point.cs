using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int xPos;
        public int yPos;
        public char symbol;

        public Point(int xPos, int yPos, char symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.symbol = symbol;
        }

        public Point(Point point)
        {
            this.xPos = point.xPos;
            this.yPos = point.yPos;
            this.symbol = point.symbol;
        }

        public void ChangeDirection(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                xPos = xPos + offset;

            if (direction == Direction.LEFT)
                xPos = xPos - offset;

            if (direction == Direction.UP)
                yPos = yPos - offset;

            if (direction == Direction.DOWN)
                yPos = yPos + offset;
        }
        public void DrawPoint()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(symbol);
        }

        public void ClearPoint()
        {
            symbol = ' ';
            DrawPoint();
        }
    }
}
