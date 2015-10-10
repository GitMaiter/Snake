using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int mapWidht;
        private int mapHeight;
        private char foodSympol;

        Random random = new Random();
        public FoodCreator(int mapWidht, int mapHeight, char foodSympol)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.foodSympol = foodSympol;
        }

        public Point CreateFood()
        {
            int xPos = random.Next(2, mapWidht - 2);
            int yPos = random.Next(2, mapHeight- 2);
            return new Point(xPos, yPos, foodSympol);
        }
    }
}
