using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Hero : Figure
    {
        private Direction direction;
        public Hero(Point tail, int lenght, Direction direction)
        {
            this.direction = direction;
            pointList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(tail);
                point.ChangeDirection(i, direction);
                pointList.Add(point);
            }
        }

        internal void MoveHero()
        {
            Point tailPoint = pointList.First(); // return first list element
            pointList.Remove(tailPoint); // delete last point it snake
            Point headPoint = GetNextPoint();
            pointList.Add(headPoint);

            tailPoint.ClearPoint();
            headPoint.DrawPoint();

        }

        public Point GetNextPoint()
        {
            Point headPoint = pointList.Last();
            Point nextPoint = new Point(headPoint);
            nextPoint.ChangeDirection(1, direction);
            return nextPoint;
        }

        public void ChangeDirectionKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;

            if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;

            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;

            if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        public bool Eat(Point foodPoint)
        {
           Point headPoint = GetNextPoint();
            if (headPoint.IsHit(foodPoint))
            {
                foodPoint.symbol = headPoint.symbol;
                pointList.Add(foodPoint);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            throw new NotImplementedException();
        }
    }
}
