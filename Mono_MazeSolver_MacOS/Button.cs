using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_MazeSolver_MacOS
{
    public class Button
    {
        int ButtonX { get; }
        int ButtonY { get; }
        string Name;
        Texture2D Texture;

        public Button(string name, Texture2D texture, int buttonX, int buttonY)
        {
            this.Name = name;
            this.Texture = texture;
            this.ButtonX = buttonX;
            this.ButtonY = buttonY;
        }



        public void Update(MouseState state, GameTime gameTime)
        {
            int posX = state.Position.X;
            int posY = state.Position.Y;

            if (
                (posX < ButtonX + Texture.Width && posX > ButtonX && posY < ButtonY + Texture.Height && posY > ButtonY)
                &&
                (state.LeftButton == ButtonState.Pressed)
                )
            {
                Console.WriteLine("Test");
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Rectangle((int)ButtonX, (int)ButtonY, Texture.Width, Texture.Height), Color.White);
        }
    }
}








