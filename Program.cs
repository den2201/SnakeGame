using Snake.Domain;
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
            const int widthPole = 76;
            const int highPole = 20;
            List<Figure> figuresList = new List<Figure>();
            Walls walls = new Walls(widthPole, highPole);
            figuresList.Add(walls);
            Figure fsnake = new Domain.Snake(new Point {X=10,Y=10,Symb = '*'}, 5, Direction.RIGTH);
            figuresList.Add(fsnake);
            Point food = new FoodCreater(widthPole, highPole, '$').CreateFood();
            food.Draw();
            Draw(figuresList);
            Domain.Snake snake = (Domain.Snake)fsnake;
            while (true)
            {
                //if (Crash(walls, snake))
                //    break;
                if((walls.IsHit(snake) || (snake.IsHitTail())))
                {
                    break;
                }
               
                if(snake.Eat(food))
                {
                    food = new FoodCreater(76, 26, '$').CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    snake.HandledKey(Console.ReadKey());
                }
               
            }
        }

        public static bool Crash(Walls walls, Domain.Snake snake)
        {
            if (walls.IsHit(snake) || snake.IsHitTail())
                return true;
            else return false;
        }
        public static void Draw(List<Figure> figures)
        {
            foreach (var i in figures)
            {
                i.Draw();
            }

        }
    }
}
