using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class Maze
    {
        List<List<MazeTile>> mazeTiles;

        public Maze(ContentManager Content)
        {
            mazeTiles = new List<List<MazeTile>>();

            for (var row = 0; row < 23; row++)
            {
                List<MazeTile> rowTiles = new List<MazeTile>();
                List<string> rowStrings = new List<string>();

                for (int element = 0; element < 25; element++)
                {
                    MazeTile tile = new MazeTile(Content, "NotWall", new Rectangle(element * 20, 40 + row * 20, 20, 20));
                    string mazeString = " ";

                    rowTiles.Add(tile);
                    rowStrings.Add(mazeString);
                }
                mazeTiles.Add(rowTiles);
            }

        }


        public void Update(MouseState mouseState, KeyboardState keyboardState)
        {
            foreach (var i in mazeTiles)
            {
                foreach (var item in i)
                {
                    item.Update(mouseState, keyboardState, mazeTiles);
                }
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var i in mazeTiles)
            {
                foreach (var item in i)
                {
                    item.Draw(spriteBatch);
                }
            }
        }
    }
}
