using System;
using System.Collections.Generic;
using Main_Maze_Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMazeSolver
{

    [TestClass]
    public class Test_Maze_Class
    {

        [TestMethod]
        public void Test_StartPoint()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });
            myMaze.Add(new List<string>() { " ", " ", " " });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.StartPoint.X == 1 && maze.StartPoint.Y == 0);
        }


        [TestMethod]
        public void Test_EndPoint()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });
            myMaze.Add(new List<string>() { " ", " ", " " });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.EndPoint.X == 2 && maze.EndPoint.Y == 1);
        }


        [TestMethod]
        public void Test_Width()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.Width == 3);
        }


        [TestMethod]
        public void Test_Heigh()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.Height == 2);
        }


        [TestMethod]
        public void Test_GetString()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });

            Maze maze = new Maze(myMaze);
            var result = maze.GetString(new Point(2, 1));

            Assert.IsTrue(result == "e");
        }


        [TestMethod]
        public void Test_SetString()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { " ", "s", " " });
            myMaze.Add(new List<string>() { " ", " ", "e" });

            Maze maze = new Maze(myMaze);

            maze.SetString(new Point(2, 1), "t");

            var result = maze.GetString(new Point(2, 1));

            Assert.IsTrue(result == "t");
        }


        [TestMethod]
        public void Test_Set_Up()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { "1", " ", "3" });
            myMaze.Add(new List<string>() { "4", "5", "6" });
            myMaze.Add(new List<string>() { "7", "8", "9" });

            Maze maze = new Maze(myMaze);

            maze.Set_Up(new Point(1, 1), "x");

            Assert.IsTrue(maze.GetString(new Point(1, 0)) == "x");
        }


        [TestMethod]
        public void Test_Set_Down()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { "1", "2", "3" });
            myMaze.Add(new List<string>() { "4", "5", "6" });
            myMaze.Add(new List<string>() { "7", " ", "9" });

            Maze maze = new Maze(myMaze);

            maze.Set_Down(new Point(1, 1), "x");

            Assert.IsTrue(maze.GetString(new Point(1, 2)) == "x");
        }


        [TestMethod]
        public void Test_Set_Right()
        {
            List<List<string>> myMaze = new List<List<string>>();
            myMaze.Add(new List<string>() { "1", "2", "3" });
            myMaze.Add(new List<string>() { "4", "5", " " });
            myMaze.Add(new List<string>() { "7", "8", "9" });

            Maze maze = new Maze(myMaze);

            maze.Set_Right(new Point(1, 1), "x");

            Assert.IsTrue(maze.GetString(new Point(2, 1)) == "x");
        }
    }
}