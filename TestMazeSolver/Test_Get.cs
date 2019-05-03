using System;
using System.Collections.Generic;
using Main_Maze_Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMazeSolver
{

    //[TestClass]
    public class Test_Get
    {
        //[TestMethod]
        public void Test_Get_Up()
        {
            List<List<char>> maze = new List<List<char>>();
            maze.Add(new List<char>() { ' ', ' ', ' ', ' ', 'x' });
            maze.Add(new List<char>() { ' ', ' ', ' ', ' ', ' ' });
            maze.Add(new List<char>() { 'x', ' ', 's', ' ', ' ' });
            maze.Add(new List<char>() { ' ', ' ', 'x', ' ', ' ' });
            maze.Add(new List<char>() { ' ', ' ', ' ', ' ', ' ' });
            maze.Add(new List<char>() { ' ', ' ', 'x', ' ', 'e' });

            List<List<char>> mazeExpected = new List<List<char>>();
            mazeExpected.Add(new List<char>() { '4', '3', '2', '3', 'x' });
            mazeExpected.Add(new List<char>() { '3', '2', '1', '2', '3' });
            mazeExpected.Add(new List<char>() { 'x', '1', 's', '1', '2' });
            mazeExpected.Add(new List<char>() { '3', '2', 'x', '2', '3' });
            mazeExpected.Add(new List<char>() { '4', '3', '4', '3', '4' });
            mazeExpected.Add(new List<char>() { '5', '4', 'x', '4', 'e' });
        }

    }
}