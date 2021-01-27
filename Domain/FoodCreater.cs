using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
   public class FoodCreater
    {
        int mapX;
        int mapY;
        Char symb;


        public FoodCreater(int x, int y, char symb)
        {
            mapX = x;
            mapY = y;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            Random r = new Random();
            int x = r.Next(2, mapX - 2);
            int y = r.Next(2, mapY - 2);
            return  new Point(x, y, symb);
        }

    }
}
