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
        string[,] myMaze;

        int mazeWide;
        int mazeHeigh;

        Texture2D pathTexture;
        Texture2D startTexture;
        Texture2D endTexture;
        Texture2D wallTexture;
        Texture2D notWallTexture;


        public Maze(string[,] myMaze, ContentManager Content)
        {
            this.myMaze = myMaze;

            this.mazeWide = myMaze.GetLength(1);
            this.mazeHeigh = myMaze.GetLength(0);

            this.pathTexture = Content.Load<Texture2D>("Path");
            this.startTexture = Content.Load<Texture2D>("Start");
            this.endTexture = Content.Load<Texture2D>("End");
            this.wallTexture = Content.Load<Texture2D>("Wall");
            this.notWallTexture = Content.Load<Texture2D>("NotWall");
        }

        public void Update(KeyboardState tecla)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int raw = 0; raw < mazeWide; raw++)
            {
                for(int element = 0;  element < mazeHeigh; element++)
                {
                    if(myMaze[element,raw] == "*")
                    {
                        spriteBatch.Draw(pathTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (myMaze[element, raw] == " ")
                    {
                        spriteBatch.Draw(notWallTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (myMaze[element, raw] == "x")
                    {
                        spriteBatch.Draw(wallTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (myMaze[element, raw] == "s")
                    {
                        spriteBatch.Draw(startTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                    else if (myMaze[element, raw] == "e")
                    {
                        spriteBatch.Draw(endTexture, new Vector2(raw * 20, element * 20), Color.White);
                    }
                }
            }
        }

    }
}
