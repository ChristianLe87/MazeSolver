using System;
namespace Main_Maze_Solver
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point Get_Up()
        {
            return new Point(X, Y - 1);
        }

        public Point Get_Down()
        {
            return new Point(X, Y + 1);
        }

        public Point Get_Right()
        {
            return new Point(X + 1, Y);
        }

        public Point Get_Left()
        {
            return new Point(X - 1, Y);
        }
    }
}