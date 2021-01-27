using Snake.Domain;
using System;

public class Point
{
    public int X { get; set; }
    public int Y{ get; set; }

    public char Symb { get; set; }

    public Point()
    {

    }
    public Point(int x = 0, int y = 0, char symb = '*')
	{
        X = x;
        Y = y;
        Symb = symb;
	}

    public Point(Point p)
    {
        X = p.X;
        Y = p.Y;
        Symb = p.Symb;
    }


    public void Move(int offset, Direction direction)
    {
        if (direction == Direction.RIGTH)
            X += offset;
        else if (direction == Direction.LEFT)
            X -= offset;
        else if (direction == Direction.UP)
            Y -= offset;
        else if (direction == Direction.DOWN)
            Y += offset;
    }

    public override string ToString()
    {
        return String.Format($"{0} {1} {2}", X, Y, Symb);
    }
    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
       
        Console.Write(Symb);
    }

    public void Clear()
    {
        Symb = ' ';
        Draw();
    }

    internal bool IsHit(Point food)
    {
        return X == food.X && Y == food.Y;
    }
}
