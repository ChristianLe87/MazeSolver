using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_MazeSolver_MacOS
{
    public class Maze
    {
        //string[,] maze;

        int mazeWide;
        int mazeHeigh;

        Texture2D pathTexture;
        Texture2D startTexture;
        Texture2D endTexture;
        Texture2D wallTexture;
        Texture2D notWallTexture;

        public string[,] maze { get; }

        public Point StartPoint { get; }
        public Point EndPoint { get; }

        public int Height { get; }
        public int Width { get; }


        public Maze(string[,] myMaze, ContentManager Content)
        {
            this.maze = myMaze;
            this.maze = maze;
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.StartPoint = GetStartPoint();
            this.EndPoint = GetEndPoint();



            this.mazeWide = myMaze.GetLength(1);
            this.mazeHeigh = myMaze.GetLength(0);

            this.pathTexture = Content.Load<Texture2D>("Path");
            this.startTexture = Content.Load<Texture2D>("Start");
            this.endTexture = Content.Load<Texture2D>("End");
            this.wallTexture = Content.Load<Texture2D>("Wall");
            this.notWallTexture = Content.Load<Texture2D>("NotWall");
        }


        private int GetWidth()
        {
            return maze.GetLength(1);
        }

        private int GetHeight()
        {
            return maze.GetLength(0);
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
                return maze[point.Y, point.X];
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
        public void SetElement(Point point, string val, bool forceSet = false)
        {
            if ((point.X <= Width - 1) && (point.X >= 0) && (point.Y <= Height - 1) && (point.Y >= 0))
            {
                if (forceSet)
                {
                    maze[point.Y, point.X] = val;
                }
                else if (maze[point.Y, point.X] == " ")
                {
                    maze[point.Y, point.X] = val;
                }
            }
        }

        public void Set_Up(Point point, string val, bool forceSet = false)
        {
            if (forceSet)
            {
                SetElement(point.Up, val, forceSet);
            }
            else if (point.Up.Y >= 0 && GetElement(point.Up) == " ")
            {
                SetElement(point.Up, val);
            }
        }

        public void Set_Down(Point point, string val, bool forceSet = false)
        {
            if (forceSet)
            {
                SetElement(point.Down, val, forceSet);
            }
            else if ((point.Down.Y <= Height - 1) && (GetElement(point.Down) == " "))
            {
                SetElement(point.Down, val);
            }
        }

        public void Set_Right(Point point, string val, bool forceSet = false)
        {
            if (forceSet)
            {
                SetElement(point.Right, val, forceSet);
            }
            else if (point.Right.X <= Width && GetElement(point.Right) == " ")
            {
                SetElement(point.Right, val);
            }
        }

        public void Set_Left(Point point, string val, bool forceSet = false)
        {
            if (forceSet)
            {
                SetElement(point.Left, val, forceSet);
            }
            else if (point.Left.X <= Width && GetElement(point.Left) == " ")
            {
                SetElement(point.Left, val);
            }
        }
        #endregion



        public void Update(KeyboardState tecla)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int raw = 0; raw < mazeWide; raw++)
            {
                for(int element = 0;  element < mazeHeigh; element++)
                {
                    if(maze[element,raw] == "*")
                    {
                        spriteBatch.Draw(pathTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (maze[element, raw] == " ")
                    {
                        spriteBatch.Draw(notWallTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (maze[element, raw] == "x")
                    {
                        spriteBatch.Draw(wallTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (maze[element, raw] == "s")
                    {
                        spriteBatch.Draw(startTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (maze[element, raw] == "e")
                    {
                        spriteBatch.Draw(endTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                }
            }
        }

    }
}
