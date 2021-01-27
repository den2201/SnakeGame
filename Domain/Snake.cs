using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
    public class Snake:Figure
    {
       Direction direction;
        public Snake(Point pointTail, int length, Direction direction)
        {
            pList = new List<Point>();
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                var point = new Point(pointTail);
                point.Move(i, direction);
                pList.Add(point);
            }

        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();

        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }
        public bool IsHitTail()
        {
            var head = pList.Last();

            for(int i = 0; i < pList.Count-2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;

        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(food))
            {
                food.Clear();
                food.Symb = head.Symb;
                pList.Add(food);
                return true;
            }
            return false;
        }

        public void HandledKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key.Key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key.Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.RightArrow)
                direction = Direction.RIGTH;
        }
    }
}
