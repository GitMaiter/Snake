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

            HorizontalLine downHorizontalLine = new HorizontalLine(0, 119, 25, '+'); // Down horizontal line (xLeft,  xRight,  y,  symbol)
            downHorizontalLine.DrawFigure();
            HorizontalLine upHorizontalLine = new HorizontalLine(0, 119, 0, '+'); // Up horizontal line (xLeft,  xRight,  y,  symbol)
            upHorizontalLine.DrawFigure();

            VerticalLine leftVerticalLine = new VerticalLine(0, 25, 0, '+');  // Left vertical line (yUp,  yDown,  x,  symbol)
            leftVerticalLine.DrawFigure();
            VerticalLine rightVerticalLine = new VerticalLine(0, 25, 119, '+'); // Right vertical line (yUp,  yDown,  x,  symbol)
            rightVerticalLine.DrawFigure();


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ChangeDirectionKey(key.Key);
                }

                Thread.Sleep(300);
                snake.MoveHero();

            }

        }
    }
}
