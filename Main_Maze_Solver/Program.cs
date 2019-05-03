using System;
using System.Collections.Generic;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', ' ', ' ', ' ', 'x' });
            myMaze.Add(new List<char>() { ' ', ' ', ' ', ' ', ' ' });
            myMaze.Add(new List<char>() { 'x', ' ', 's', ' ', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'x', ' ', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', ' ', ' ', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'x', ' ', 'e' });

            var maze = new Maze(myMaze);
            Tools.FillWithNumbers(maze);

            Tools.PrintMaze(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
