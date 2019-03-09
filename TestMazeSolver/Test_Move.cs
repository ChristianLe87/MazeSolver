using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMazeSolver
{
    [TestClass]
    public class Test_Move
    {
        [TestMethod]
        public void Test_Move_Up()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            int[] result = MazeSolver.Move.Up(actual_Position, maze);

            Assert.IsTrue(result[0] == 0 && result[1] == 1);
        }

        [TestMethod]
        public void Test_Move_Down()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Move.Down(actual_Position, maze);

            Assert.IsTrue(result[0] == 2 && result[1] == 1);
        }

        [TestMethod]
        public void Test_Move_Right()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Move.Right(actual_Position, maze);

            Assert.IsTrue(result[0] == 1 && result[1] == 2);
        }

        [TestMethod]
        public void Test_Move_Left()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Move.Left(actual_Position, maze);

            Assert.IsTrue(result[0] == 1 && result[1] == 0);
        }
    }


}