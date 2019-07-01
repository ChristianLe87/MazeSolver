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
        List<List<Button>> maze;


        public Maze(ContentManager Content)
        {
            maze = new List<List<Button>>();

            // create one row
            //List<Button> row = new List<Button>();

            for (var row = 0; row < 23; row++)
            {
                List<Button> elementButton = new List<Button>();
                for (int element = 0; element < 25; element++)
                {
                    Button button = new Button(Content, "NotWall", new Rectangle(element * 20, 40 + row * 20, 20, 20));
                    elementButton.Add(button);
                }
                maze.Add(elementButton);
            }

        }


        public void Update(MouseState mouseState)
        {
            foreach (var i in maze)
            {
                foreach (var item in i)
                {
                    item.Update(mouseState);
                }
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var i in maze)
            {
                foreach (var item in i)
                {
                    item.Draw(spriteBatch);
                }
            }
        }
    }
}
