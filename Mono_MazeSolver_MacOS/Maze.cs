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
        //Rectangle playerPosition;
        string[,] myMaze;

        Texture2D pathTexture;
        Texture2D startTexture;
        Texture2D endTexture;
        Texture2D wallTexture;
        Texture2D notWallTexture;


        public Maze(string[,] myMaze, ContentManager Content)
        {
            this.myMaze = myMaze;

            pathTexture = Content.Load<Texture2D>("Path");
            startTexture = Content.Load<Texture2D>("Start");
            endTexture = Content.Load<Texture2D>("End");
            wallTexture = Content.Load<Texture2D>("Wall");
            notWallTexture = Content.Load<Texture2D>("NotWall");
        }

        public void Update(KeyboardState tecla)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Path, new Vector2(x*20,y*20), Color.White); // Color.White es opcional
            for (int raw = 0; raw < 9; raw++)
            {
                for(int element = 0;  element <6; element++)
                {
                    //Console.WriteLine(myMaze[element, raw]);
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
