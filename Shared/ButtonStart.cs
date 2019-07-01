using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class ButtonStart
    {
        Rectangle rectangle;
        Texture2D Texture_Start;

        public ButtonStart(ContentManager Content, Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.Texture_Start = Content.Load<Texture2D>("ButtonStart");
        }


        public void Update(MouseState state )
        {
            int posX = state.Position.X;
            int posY = state.Position.Y;

            if (
                (posX < rectangle.X + 20 && posX > rectangle.X && posY < rectangle.Y + 20 && posY > rectangle.Y)
                &&
                (state.LeftButton == ButtonState.Pressed)
                )
            {
                //Name = "Wall";
            }
        }
    }
}
