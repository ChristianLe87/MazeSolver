﻿using System;
using System.Collections.Generic;
using System.Linq;

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

            var up = maze.Get_Up(end);
            var down = maze.Get_Down(end);
            var right = maze.Get_Right(end);
            var left = maze.Get_Left(end);

            // Get just numbers and order
            List<string> strElements = new List<string>() { up, down, right, left };
            strElements = strElements
                            .Where(x => x != "x")
                            .Where(x=> x != "s")
                            .Where(x => x != "e")
                            .Where(x => x != "*")
                            .Distinct()
                            .ToList();

            var intElements = strElements
                            .Select(x => Int32.Parse(x))
                            .OrderBy(x => x)
                            .Distinct()
                            .ToList();


            for (var i = intElements.FirstOrDefault(); i > 0; --i)
            {
                if (up == i.ToString())
                {
                    maze.Set_Up(end, "*",true);
                    end = end.Up;

                    up = maze.Get_Up(end);
                    down = maze.Get_Down(end);
                    right = maze.Get_Right(end);
                    left = maze.Get_Left(end);
                }
                else if (down == i.ToString())
                {
                    maze.Set_Down(end, "*", true);
                    end = end.Down;

                    up = maze.Get_Up(end);
                    down = maze.Get_Down(end);
                    right = maze.Get_Right(end);
                    left = maze.Get_Left(end);
                }
                else if (right == i.ToString())
                {
                    maze.Set_Right(end, "*", true);
                    end = end.Right;

                    up = maze.Get_Up(end);
                    down = maze.Get_Down(end);
                    right = maze.Get_Right(end);
                    left = maze.Get_Left(end);
                }
                else if (left == i.ToString())
                {
                    maze.Set_Left(end, "*", true);
                    end = end.Left;

                    up = maze.Get_Up(end);
                    down = maze.Get_Down(end);
                    right = maze.Get_Right(end);
                    left = maze.Get_Left(end);
                }
            }

        }

        public static void UpDownRightLeft(Maze maze, Point point, string val)
        {
            maze.Set_Up(point, val);
            maze.Set_Down(point, val);
            maze.Set_Right(point, val);
            maze.Set_Left(point, val);
        }

        public static void PrintMaze(Maze maze)
        {
            foreach (var row in maze.maze)
            {
                foreach (var element in row)
                {
                    Console.Write($" {element} ");
                }
                Console.WriteLine();
            }
        }

    }
}