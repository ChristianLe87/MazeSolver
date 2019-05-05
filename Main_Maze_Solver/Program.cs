using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { "s", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", "e" });

            var maze = new Maze(myMaze);
            Tools.FillWithNumbers(maze);

            Tools.GetShortestPath(maze);
            Tools.PrintMaze(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
