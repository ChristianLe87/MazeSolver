﻿using System;
namespace MazeSolver
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

        public Point Up
        {
            get
            {
                return new Point(X, Y - 1);
            }
        }

        public Point Down
        {
            get
            {
                return new Point(X, Y + 1);
            }
        }

        public Point Right
        {
            get
            {
                return new Point(X + 1, Y);
            }
        }

        public Point Left
        {
            get
            {
                return new Point(X - 1, Y);
            }
        }
    }
}