using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
    public class Walls:Figure
    {
       List<Figure> walls = new List<Figure>();
       private HorizontalLine horLineUp;
       private HorizontalLine horLineDown;
       private VerticalLine vertLineLeft;
       private VerticalLine vertLineRight;
       private char symb = '#';

        public Walls(int width, int high)
        {
            horLineUp = new HorizontalLine(1, width, 0, symb);
            horLineDown = new HorizontalLine(0, width, high, symb);
            vertLineLeft = new VerticalLine(0, high, 0, symb);
            vertLineRight = new VerticalLine(0, high, width, symb);
            walls.Add(horLineDown);
            walls.Add(horLineUp);
            walls.Add(vertLineLeft);
            walls.Add(vertLineRight);
        }

        public override void Draw()
        {
            foreach(var wall in walls)
            {
                wall.Draw();
            }
        }

        public bool IsHit (Figure figure)
        {
            foreach(var wall in walls)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

    }
}
