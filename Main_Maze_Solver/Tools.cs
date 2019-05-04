using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    public static class Tools
    {

        internal static void FillWithNumbers(Maze maze)
        {
            int maxNumb = maze.Width * maze.Height;

            // List of possible numbers
            List<string> possibles = new List<string>();
            possibles.Add("s");
            for (var i = 0; i < maxNumb; ++i)
            {
                possibles.Add($"{i}");
            }


            for (var possible = 0; possible < possibles.Count-1; ++possible)
            {
                for (var row = 0; row < maze.Height; ++row)
                {
                    for (var element = 0; element < maze.Width; ++element)
                    {
                        var point = new Point(row, element);
                        if (maze.GetString(point) == possibles[possible])
                        {
                            maze.Set_Up(point, possibles[possible + 1]);
                            maze.Set_Down(point, possibles[possible + 1]);
                            maze.Set_Right(point, possibles[possible + 1]);
                            maze.Set_Left(point, possibles[possible + 1]);
                        }
                    }
                }
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
