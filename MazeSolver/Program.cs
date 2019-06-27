<<<<<<< Updated upstream:MazeSolver/Program.cs
﻿using System;

namespace MazeSolver
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
=======
﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main()
        {


            FileManager coolFile = new FileManager("coolFile.txt");

            if (coolFile.FileExist())
            {
                var myFile = coolFile.ReadFile();
                foreach (var i in myFile)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                List<List<string>> myMaze = new List<List<string>>();

                myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
                myMaze.Add(new List<string>() { " ", " ", " ", " ", "x", " ", " ", " ", " " });
                myMaze.Add(new List<string>() { " ", "x", "x", " ", " ", " ", " ", "x", " " });
                myMaze.Add(new List<string>() { " ", "s", " ", "x", "x", " ", " ", "x", " " });
                myMaze.Add(new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", " " });
                myMaze.Add(new List<string>() { " ", " ", "x", " ", " ", " ", " ", "x", "e" });
                coolFile.CreateFile(myMaze);
            }



            /*var maze = new Maze(myMaze);

            Tools.FillWithNumbers(maze);

            Tools.GetShortestPath(maze);

            Tools.CleanMaze(maze);

            Tools.PrintMaze(maze);*/

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

    }
}
>>>>>>> Stashed changes:Main_Maze_Solver/Program.cs
