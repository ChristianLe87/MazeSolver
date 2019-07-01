using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class Button
    {

        public string Name { get; set; }
        Texture2D Texture_NotWall;
        Texture2D Texture_Wall;
        Texture2D Texture_Path;
        Texture2D Texture_Start;
        Texture2D Texture_End;
        Rectangle rectangle;


        public Button(ContentManager Content, string name, Rectangle rectangle)
        {
            // Define textures
            this.Texture_End = Content.Load<Texture2D>("End");
            this.Texture_NotWall = Content.Load<Texture2D>("NotWall");
            this.Texture_Path = Content.Load<Texture2D>("Path");
            this.Texture_Start = Content.Load<Texture2D>("Start");
            this.Texture_Wall = Content.Load<Texture2D>("Wall");

            this.Name = name;
            this.rectangle = rectangle;
        }


        public void Update(MouseState state)
        {
            int posX = state.Position.X;
            int posY = state.Position.Y;

            if (
                (posX < rectangle.X + 20 && posX > rectangle.X && posY < rectangle.Y + 20 && posY > rectangle.Y)
                &&
                (state.LeftButton == ButtonState.Pressed)
                )
            {
                Name = "Wall";
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            switch (Name)
            {
                case "NotWall":
                    spriteBatch.Draw(Texture_NotWall, rectangle, Color.White);
                    break;
                case "Wall":
                    spriteBatch.Draw(Texture_Wall, rectangle, Color.White);
                    break;
                case "Path":
                    spriteBatch.Draw(Texture_Path, rectangle, Color.White);
                    break;
                case "Start":
                    spriteBatch.Draw(Texture_Start, rectangle, Color.White);
                    break;
                case "End":
                    spriteBatch.Draw(Texture_End, rectangle, Color.White);
                    break;
                default:
                    break;
            }            
        }

    }
}
