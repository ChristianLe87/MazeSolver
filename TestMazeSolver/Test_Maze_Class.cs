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
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });
            myMaze.Add(new List<char>() { ' ', ' ', ' ' });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.StartPoint.X == 1 && maze.StartPoint.Y == 0);
        }



        [TestMethod]
        public void Test_EndPoint()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });
            myMaze.Add(new List<char>() { ' ', ' ', ' ' });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.EndPoint.X == 2 && maze.EndPoint.Y == 1);
        }

        [TestMethod]
        public void Test_Width()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.Width == 3);
        }

        [TestMethod]
        public void Test_Heigh()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });

            Maze maze = new Maze(myMaze);

            Assert.IsTrue(maze.Height == 2);
        }

        [TestMethod]
        public void Test_GetChar()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });

            Maze maze = new Maze(myMaze);
            var result = maze.GetChar(new Point(2, 1));

            Assert.IsTrue(result == 'e');
        }

        [TestMethod]
        public void Test_SetChar()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { ' ', 's', ' ' });
            myMaze.Add(new List<char>() { ' ', ' ', 'e' });

            Maze maze = new Maze(myMaze);

            maze.SetChar(new Point(2, 1), 't');

            var result = maze.GetChar(new Point(2, 1));

            Assert.IsTrue(result == 't');
        }

        [TestMethod]
        public void Test_Set_Up()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { '1', '2', '3' });
            myMaze.Add(new List<char>() { '4', '5', '6' });
            myMaze.Add(new List<char>() { '7', '8', '9' });

            Maze maze = new Maze(myMaze);

            maze.Set_Up(new Point(1, 1), 'x');

            Assert.IsTrue(maze.GetChar(new Point(1, 0)) == 'x');
        }

        [TestMethod]
        public void Test_Set_Down()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { '1', '2', '3' });
            myMaze.Add(new List<char>() { '4', '5', '6' });
            myMaze.Add(new List<char>() { '7', '8', '9' });

            Maze maze = new Maze(myMaze);

            maze.Set_Down(new Point(1, 1), 'x');

            Assert.IsTrue(maze.GetChar(new Point(1, 2)) == 'x');
        }

        [TestMethod]
        public void Test_Set_Right()
        {
            List<List<char>> myMaze = new List<List<char>>();
            myMaze.Add(new List<char>() { '1', '2', '3' });
            myMaze.Add(new List<char>() { '4', '5', '6' });
            myMaze.Add(new List<char>() { '7', '8', '9' });

            Maze maze = new Maze(myMaze);

            maze.Set_Right(new Point(1, 1), 'x');

            Assert.IsTrue(maze.GetChar(new Point(2, 1)) == 'x');
        }
    }
}