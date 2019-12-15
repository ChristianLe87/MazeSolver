using System;
using System.Collections.Generic;

namespace MazeSolver
{
    class Program
    {
        static void Main()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
            myMaze.Add(new List<string>() { " ", "x", "x", " ", " ", " ", " ", "x", " " });
            myMaze.Add(new List<string>() { " ", "s", " ", "x", "x", " ", " ", "x", " " });
            myMaze.Add(new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", " " });
            myMaze.Add(new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", "e" });

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
