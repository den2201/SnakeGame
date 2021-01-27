using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
  public  class VerticalLine:Figure
    {
        public VerticalLine(int downY, int upY, int x, char symb)
        {
            pList = new List<Point>();
            for (int i = downY; i <= upY; i++)
            {
                pList.Add(new Point(x, i, symb));
            }
        }

        public override void Draw()
        {
            base.Draw();
        }

    }
}
