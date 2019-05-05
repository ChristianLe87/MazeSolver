using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", "s", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", " ", " ", " ", "e", " " });

            var maze = new Maze(myMaze);
            Tools.FillWithNumbers(maze);

            Tools.PrintMaze(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
