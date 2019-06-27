using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoMazeSolver_MacOS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (var game = new Shared.Game1())
            {
                game.Run();
            }
        }
    }
}
