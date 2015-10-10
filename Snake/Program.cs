using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;   // Welcome to Matrix 


            Point point = new Point(10, 10, '*');
            point.Draw();

            Point point1 = new Point(7, 7, '#');
            point1.Draw();

            HorizontalLine liine = new HorizontalLine(5, 20, 8, '+');
            liine.Drow();

            Console.ReadKey();
        }
    }
}
