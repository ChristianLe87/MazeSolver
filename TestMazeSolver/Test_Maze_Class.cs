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
        public void _1_Maze_StartPoint()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " ", " ", " " },
                new List<string>() { " ", " ", "s" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.StartPoint.X == 2 && maze.StartPoint.Y == 1);
        }


        [TestMethod]
        public void _2_Maze_EndPoint()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " ", " ", " " },
                new List<string>() { " ", " ", "e" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.EndPoint.X == 2 && maze.EndPoint.Y == 1);
        }


        [TestMethod]
        public void _3_1_Maze_GetElement()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.GetElement(new Point(0,0)) == "a");
        }


        [TestMethod]
        public void _3_2_Maze_GetElement_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.GetElement(new Point(1, 1)) == "x");
        }


        [TestMethod]
        public void _4_1_Maze_SetElement()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " " }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(0,0), "a");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [TestMethod]
        public void _4_2_Maze_SetElement_NotEmpty()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [TestMethod]
        public void _4_3_Maze_SetElement_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(1, 1), "b");
        }


        [TestMethod]
        public void _5_1_Maze_Set_Up()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " " },
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 1), "b");
            Assert.IsTrue(maze.GetElement(new Point(0,0)) == "b");
        }


        [TestMethod]
        public void _5_2_Maze_Set_Up_NotEmpty()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" },
                new List<string>() { "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 1), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [TestMethod]
        public void _5_3_Maze_Set_Up_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 0), "b");
        }


        [TestMethod]
        public void _6_1_Maze_Set_Down()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" },
                new List<string>() { " " }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 1)) == "b");
        }


        [TestMethod]
        public void _6_2_Maze_Set_Down_NotEmpty()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" },
                new List<string>() { "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 1)) == "b");
        }


        [TestMethod]
        public void _6_3_Maze_Set_Down_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "x");
        }


        [TestMethod]
        public void _7_1_Maze_Set_Right()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a", " " }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(1, 0)) == "b");
        }


        [TestMethod]
        public void _7_2_Maze_Set_Right_NotEmpty()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a", "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(1, 0)) == "b");
        }


        [TestMethod]
        public void _7_3_Maze_Set_Right_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "x");
        }


        [TestMethod]
        public void _8_1_Maze_Set_Left()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " ", "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(1, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "b");
        }


        [TestMethod]
        public void _8_2_Maze_Set_Left_NotEmpty()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a", "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(1, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [TestMethod]
        public void _8_3_Maze_Set_Left_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(0, 0), "x");
        }


        [TestMethod]
        public void _9_1_Maze_GetLef()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { " ", "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Left(new Point(1, 0)) == " ");
        }


        [TestMethod]
        public void _9_2_Maze_GetLef_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Left(new Point(0, 0)) == "x");
        }


        [TestMethod]
        public void _10_1_Maze_GetRight()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a", "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Right(new Point(0, 0)) == "b");
        }


        [TestMethod]
        public void _10_2_Maze_GetRight_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Right(new Point(0, 0)) == "x");
        }


        [TestMethod]
        public void _11_1_Maze_GetUp()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" },
                new List<string>() { "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Up(new Point(0, 1)) == "a");
        }


        [TestMethod]
        public void _11_2_Maze_GetUp_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Up(new Point(0, 0)) == "x");
        }


        [TestMethod]
        public void _12_1_Maze_GetDown()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" },
                new List<string>() { "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Down(new Point(0, 0)) == "b");
        }


        [TestMethod]
        public void _12_2_Maze_GetDown_OutOfRange()
        {
            List<List<string>> myMaze = new List<List<string>>
            {
                new List<string>() { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Down(new Point(0, 0)) == "x");
        }
    }
}