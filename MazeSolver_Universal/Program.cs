using System;

namespace MazeSolver_Universal
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
