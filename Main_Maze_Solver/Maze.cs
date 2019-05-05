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

        public Maze() { }

        public Maze(List<List<string>> maze)
        {
            this.maze = maze;
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.StartPoint = GetStartPoint();
            this.EndPoint = GetEndPoint();
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
                    if (GetElement(point) == "s" || GetElement(point) == "S")
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
                    if (GetElement(point) == "e" || GetElement(point) == "E")
                    {
                        return point;
                    }
                }
            }
            return null;
        }

        #region Get
        public string GetElement(Point point)
        {
            if ((point.X <= Width - 1) && (point.X >= 0) && (point.Y <= Height) && (point.Y >= 0))
            {
                return maze[point.Y][point.X];
            }
            else
            {
                return "x";
            }

        }

        public string Get_Left(Point point)
        {
            if (point.Left.X <= Width)
            {
                return GetElement(point.Left);
            }
            return "x";
        }

        public string Get_Right(Point point)
        {
            if (point.Right.X <= Width)
            {
                return GetElement(point.Right);
            }
            return "x";
        }

        public string Get_Up(Point point)
        {
            if (point.Up.Y >= 0)
            {
                return GetElement(point.Up);
            }
            return "x";
        }

        public string Get_Down(Point point)
        {
            if (point.Down.Y <= Height - 1)
            {
                return GetElement(point.Down);
            }
            return "x";
        }
        #endregion

        #region Set
        public void SetElement(Point point, string val)
        {
            if ((point.X <= Width - 1) && (point.X >= 0) && (point.Y <= Height - 1) && (point.Y >= 0))
            {
                if (maze[point.Y][point.X] == " ")
                {
                    maze[point.Y][point.X] = val;
                }
            }
        }

        public void Set_Up(Point point, string val)
        {
            if (point.Up.Y >= 0 && GetElement(point.Up) == " ")
            {
                SetElement(point.Up, val);
            }
        }

        public void Set_Down(Point point, string val)
        {
            if ((point.Down.Y <= Height - 1) && (GetElement(point.Down) == " "))
            {
                SetElement(point.Down, val);
            }
        }

        public void Set_Right(Point point, string val)
        {
            if (point.Right.X <= Width && GetElement(point.Right) == " ")
            {
                SetElement(point.Right, val);
            }
        }

        public void Set_Left(Point point, string val)
        {
            if (point.Left.X <= Width && GetElement(point.Left) == " ")
            {
                SetElement(point.Left, val);
            }
        }
        #endregion
    }
}