using System;
using System.Collections.Generic;
using System.Linq;

namespace Main_Maze_Solver
{
    public class Maze
    {
        public List<List<string>> maze { get; }

        public Point StartPoint { get; }
        public Point EndPoint { get; }

        public int Height { get; }
        public int Width { get; }


        public Maze(List<List<string>> maze)
        {
            this.maze = maze;
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.StartPoint = GetStartPoint();
            this.EndPoint = GetEndPoint();
        }


        public string GetString(Point point)
        {
            return maze[point.Y][point.X];
        }

        private int GetWidth()
        {
            return maze[0].Count();
        }

        private int GetHeight()
        {
            return maze.Count();
        }

        private Point GetStartPoint()
        {
            for (var row = 0; row < Width; ++row)
            {
                for (var collumn = 0; collumn < Height; ++collumn)
                {
                    var point = new Point();
                    point.X = row;
                    point.Y = collumn;
                    if (GetString(point) == "s" || GetString(point) == "S")
                    {
                        return point;
                    }
                }
            }
            return null;
        }

        private Point GetEndPoint()
        {
            for (var row = 0; row < Width; ++row)
            {
                for (var collumn = 0; collumn < Height; ++collumn)
                {
                    var point = new Point(row, collumn);
                    if (GetString(point) == "e" || GetString(point) == "E")
                    {
                        return point;
                    }
                }
            }
            return null;
        }

        public string GetLeft(Point point)
        {
            if (point.Left.X <= Width)
            {
                return GetString(point.Left);
            }
            return "x";
        }

        public void SetString(Point point, string val)
        {
            maze[point.Y][point.X] = val;
        }

        public void Set_Up(Point point, string val)
        {
            if (point.Up.Y >= 0 && GetString(point.Up) == " ")
            {
                SetString(point.Up, val);
            }
        }

        public void Set_Down(Point point, string val)
        {
            if ((point.Down.Y <= Height) && (GetString(point.Down) == " "))
            {
                SetString(point.Down, val);
            }
        }

        public void Set_Right(Point point, string val)
        {
            if (point.Right.X <= Width && GetString(point.Right) == " ")
            {
                SetString(point.Right, val);
            }
        }


       


        public void Set_Left(Point point, string val)
        {
            if (point.Left.X <= Width && GetString(point.Left) == " ")
            {
                SetString(point.Left, val);
            }
        }
    }
}
