using MazeSolver;
using NUnit.Framework;
using System;
namespace MazeSolver_Test
{



    [TestFixture()]
    public class Test_Maze_Class
    {
        [Test()]
        public void _1_Maze_StartPoint()
        {
            string[,] myMaze = new string[,]
            {
                { " ", " ", " " },
                { " ", " ", "s" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.StartPoint.X == 2 && maze.StartPoint.Y == 1);
        }


        [Test()]
        public void _2_Maze_EndPoint()
        {
            string[,] myMaze = new string[,]
            {
                 { " ", " ", " " },
                 { " ", " ", "e" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.EndPoint.X == 2 && maze.EndPoint.Y == 1);
        }


        [Test()]
        public void _3_1_Maze_GetElement()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [Test()]
        public void _3_2_Maze_GetElement_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.GetElement(new Point(1, 1)) == "x");
        }


        [Test()]
        public void _4_1_Maze_SetElement()
        {
            string[,] myMaze = new string[,]
            {
                 { " " }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(0, 0), "a");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [Test()]
        public void _4_2_Maze_SetElement_NotEmpty()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [Test()]
        public void _4_3_Maze_SetElement_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.SetElement(new Point(1, 1), "b");
        }


        [Test()]
        public void _5_1_Maze_Set_Up()
        {
            string[,] myMaze = new string[,]
            {
                 { " " },
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 1), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "b");
        }


        [Test()]
        public void _5_2_Maze_Set_Up_NotEmpty()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" },
                 { "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 1), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [Test()]
        public void _5_3_Maze_Set_Up_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Up(new Point(0, 0), "b");
        }


        [Test()]
        public void _6_1_Maze_Set_Down()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" },
                 { " " }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 1)) == "b");
        }


        [Test()]
        public void _6_2_Maze_Set_Down_NotEmpty()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" },
                 { "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 1)) == "b");
        }


        [Test()]
        public void _6_3_Maze_Set_Down_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Down(new Point(0, 0), "x");
        }


        [Test()]
        public void _7_1_Maze_Set_Right()
        {
            string[,] myMaze = new string[,]
            {
                 { "a", " " }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(1, 0)) == "b");
        }


        [Test()]
        public void _7_2_Maze_Set_Right_NotEmpty()
        {
            string[,] myMaze = new string[,]
            {
                 { "a", "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(1, 0)) == "b");
        }


        [Test()]
        public void _7_3_Maze_Set_Right_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Right(new Point(0, 0), "x");
        }


        [Test()]
        public void _8_1_Maze_Set_Left()
        {
            string[,] myMaze = new string[,]
            {
                 { " ", "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(1, 0), "b");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "b");
        }


        [Test()]
        public void _8_2_Maze_Set_Left_NotEmpty()
        {
            string[,] myMaze = new string[,]
            {
                 { "a", "b" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(1, 0), "x");
            Assert.IsTrue(maze.GetElement(new Point(0, 0)) == "a");
        }


        [Test()]
        public void _8_3_Maze_Set_Left_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            maze.Set_Left(new Point(0, 0), "x");
        }


        [Test()]
        public void _9_1_Maze_GetLef()
        {
            string[,] myMaze = new string[,]
            {
                 { " ", "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Left(new Point(1, 0)) == " ");
        }


        [Test()]
        public void _9_2_Maze_GetLef_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Left(new Point(0, 0)) == "x");
        }


        [Test()]
        public void _10_1_Maze_GetRight()
        {
            string[,] myMaze = new string[,]
            {
                 { "a", "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Right(new Point(0, 0)) == "b");
        }


        [Test()]
        public void _10_2_Maze_GetRight_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Right(new Point(0, 0)) == "x");
        }


        [Test()]
        public void _11_1_Maze_GetUp()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" },
                 { "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Up(new Point(0, 1)) == "a");
        }


        [Test()]
        public void _11_2_Maze_GetUp_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Up(new Point(0, 0)) == "x");
        }


        [Test()]
        public void _12_1_Maze_GetDown()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" },
                 { "b" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Down(new Point(0, 0)) == "b");
        }


        [Test()]
        public void _12_2_Maze_GetDown_OutOfRange()
        {
            string[,] myMaze = new string[,]
            {
                 { "a" }
            };
            var maze = new Maze(myMaze);
            Assert.IsTrue(maze.Get_Down(new Point(0, 0)) == "x");
        }
    }
}
