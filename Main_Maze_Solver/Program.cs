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
                new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                new List<string>() { " ", "x", "x", " ", " ", " ", " ", "x", " " },
                new List<string>() { " ", "s", " ", "x", "x", " ", " ", "x", " " },
                new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", " " },
                new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", "e" }
            };

            var maze = new Maze(myMaze);

            Tools.FillWithNumbers(maze);

            Tools.GetShortestPath(maze);

            Tools.CleanMaze(maze);

            Tools.PrintMaze(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
