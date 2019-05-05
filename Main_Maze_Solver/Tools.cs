﻿using System;
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
            for (var i = 1; i < maxNumb; ++i)
            {
                possibles.Add($"{i}");
            }
            possibles.Add("e");


            // for each number
            for (var possible = 0; possible < maxNumb; ++possible)
            {
                // for each row
                for (var row = 0; row < maze.Height; ++row)
                {
                    // for each element
                    for (var element = 0; element < maze.Width; ++element)
                    {
                        if (maze.maze[row][element] == possibles[possible])
                        {
                            UpDownRightLeft(maze, new Point(element, row), possibles[possible + 1]);
                        }
                    }
                }

            }
        }

        internal static void GetShortestPath(Maze maze)
        {
            var end = maze.EndPoint;

        }

        public static void UpDownRightLeft(Maze maze, Point point,string val)
        {
            maze.Set_Up(point, val);
            maze.Set_Down(point, val);
            maze.Set_Right(point, val);
            maze.Set_Left(point, val);
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
