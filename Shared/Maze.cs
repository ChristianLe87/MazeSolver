using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mono_MazeSolver_MacOS
{
    public class Maze
    {
        List<List<string>> fileContent;
        Texture2D Texture_NotWall;
        Texture2D Texture_Wall;
        Texture2D Texture_Path;
        Texture2D Texture_Start;
        Texture2D Texture_End;
        Rectangle rectangle = new Rectangle(0, 0, 20, 20);


        public Maze(List<List<string>> fileContent)
        {
            this.fileContent = fileContent;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var line in fileContent)
            {
                foreach(var element in line)
                {
                    if(element == " ")
                    {
                        spriteBatch.Draw(Texture_NotWall, rectangle, Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(Texture_Wall, rectangle, Color.White);
                    }

                }
            }
        }
    }
}
