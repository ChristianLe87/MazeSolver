using System;
using System.Collections.Generic;
using System.Linq;

namespace Main_Maze_Solver
{
    public class Maze
    {
        public List<List<char>> maze { get; }

        public Point StartPoint { get; }
        public Point EndPoint { get; }

        public int Height { get; }
        public int Width { get; }


        public Maze(List<List<char>> maze)
        {
            this.maze = maze;
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.StartPoint = GetStartPoint();
            this.EndPoint = GetEndPoint();
        }


        public char GetChar(Point point)
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
                    if (GetChar(point) == 's' || GetChar(point) == 'S')
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
                    if (GetChar(point) == 'e' || GetChar(point) == 'E')
                    {
                        return point;
                    }
                }
            }
            return null;
        }

        public void SetChar(Point point, char val)
        {
            maze[point.Y][point.X] = val;
        }

        public void Set_Up(Point point, char val)
        {
            int nX = point.X;
            int nY = point.Y-1;

            if(nY >= 0)
            {
                SetChar(new Point(nX, nY),val);
            }
        }

        public void Set_Down(Point point, char val)
        {
            int nX = point.X;
            int nY = point.Y + 1;

            if (nY <= Height)
            {
                SetChar(new Point(nX, nY), val);
            }
        }

        public void Set_Right(Point point, char val)
        {
            int nX = point.X + 1;
            int nY = point.Y;

            if (nY <= Width)
            {
                SetChar(new Point(nX, nY), val);
            }
        }

        public void Set_Left(Point point, char val)
        {
            int nX = point.X + 1;
            int nY = point.Y;

            if (nY <= Width)
            {
                SetChar(new Point(nX, nY), val);
            }
        }
    }
}