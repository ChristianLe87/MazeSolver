using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mono_MazeSolver_MacOS
{
    public class Maze
    {
        List<List<string>> maze;
        Texture2D Texture_NotWall;
        Texture2D Texture_Wall;
        Texture2D Texture_Path;
        Texture2D Texture_Start;
        Texture2D Texture_End;
        Rectangle rectangle = new Rectangle(0, 0, 20, 20);


        public Maze(ContentManager Content)
        {
            maze = new List<List<string>>();

            // create one row
            List<string> row = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                row.Add(" ");
            }

            // insert rows into maze
            for(var i = 0; i < 5; i++)
            {
                maze.Add(row);
            }




            // Define textures
            this.Texture_End = Content.Load<Texture2D>("abc");
            this.Texture_NotWall = Content.Load<Texture2D>("abc");
            this.Texture_Path = Content.Load<Texture2D>("abc");
            this.Texture_Start = Content.Load<Texture2D>("abc");
            this.Texture_Wall = Content.Load<Texture2D>("abc");



        }


        public void Update()
        {
        }


        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
