using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main()
        {
            string[,] myMaze = new string[,]
            {
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", "x", "x", " ", " ", " ", " ", "x", " " },
                { " ", "s", " ", "x", "x", " ", " ", "x", " " },
                { " ", " ", "x", " ", " ", " ", " ", "x", " " },
                { " ", " ", "x", " ", " ", " ", " ", "x", "e" }
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
