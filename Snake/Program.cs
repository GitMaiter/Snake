using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;   // Welcome to the Matrix 

            Console.SetBufferSize(120, 30); // Set console window size 

            Point point = new Point(4, 5, '@'); // Start snake position and default snake symbol
            Hero snake = new Hero(point, 4, Direction.RIGHT); // point = start dir. position and snake symbol, 4 = default snake lenght, default direction
            snake.DrawFigure();

            FoodCreator foodCreator = new FoodCreator(100, 25, '#'); // Max range of food spawn and default food symbol
            Point foodPoint = foodCreator.CreateFood();
            foodPoint.DrawPoint();

            Walls walls = new Walls(120, 25); // Max x and y position of walls
            walls.DrawWalls();

            while (true)
            {

                if (snake.Eat(foodPoint))
                {
                    foodPoint = foodCreator.CreateFood();
                    foodPoint.DrawPoint();
                } else
                {
                    snake.MoveHero();
                }
                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ChangeDirectionKey(key.Key);
                }

            }

        }
    }
}
