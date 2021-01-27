using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
   public class HorizontalLine:Figure
    {
     
       public HorizontalLine(int leftX, int rightX, int y, char symb)
        {
            pList = new List<Point>();
           for(int i = leftX; i <= rightX; i++)
            {
                pList.Add(new Point(i, y, symb));
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor =  ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
