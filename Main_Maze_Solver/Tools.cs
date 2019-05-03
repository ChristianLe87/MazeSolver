using System;
namespace Main_Maze_Solver
{
    public static class Tools
    {

        internal static void FillWithNumbers(Maze maze)
        {
            int maxNumb = maze.Width * maze.Height;
            for(var i = 0; i < maxNumb; ++i)
            {

            }
        }

        public static void PrintMaze(Maze maze)
        {
            foreach(var row in maze.maze)
            {
                foreach( var element in row)
                {
                    Console.Write($" {element} ");
                }
                Console.WriteLine();
            }
        }
    }
}
