using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "s", " ", " ", " ", " ", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", "e" }
            };

            var maze = new Maze(myMaze);
            Tools.FillWithNumbers(maze);

            Tools.GetShortestPath(maze);
            Tools.PrintMaze(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
