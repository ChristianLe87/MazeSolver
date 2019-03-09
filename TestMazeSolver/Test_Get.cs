using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMazeSolver
{
   [TestClass]
    public class Test_Get
    {
        [TestMethod]
        public void Test_Get_Up()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.Up(actual_Position, maze);

            Assert.IsTrue('2' == result);
        }

        [TestMethod]
        public void Test_Get_Down()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.Down(actual_Position, maze);

            Assert.IsTrue('8' == result);
        }

        [TestMethod]
        public void Test_Get_Right()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.Right(actual_Position, maze);

            Assert.IsTrue('6' == result);

        }

        [TestMethod]
        public void Test_Get_Left()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.Left(actual_Position, maze);

            Assert.IsTrue('4' == result);
        }

        [TestMethod]
        public void Test_Get_Down_Right()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.DownRight(actual_Position, maze);

            Assert.IsTrue('9' == result);
        }

        [TestMethod]
        public void Test_Get_Down_Left()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.DownLeft(actual_Position, maze);

            Assert.IsTrue('7' == result);
        }

        [TestMethod]
        public void Test_Get_Up_Right()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.UpRight(actual_Position, maze);

            Assert.IsTrue('3' == result);
        }

        [TestMethod]
        public void Test_Get_Up_Left()
        {
            var maze = new char[,] {
            { '1', '2', '3',},
            { '4', '5', '6',},
            { '7', '8', '9', }
            };

            int[] actual_Position = new int[] { 1, 1 };

            var result = MazeSolver.Get.UpLeft(actual_Position, maze);

            Assert.IsTrue('1' == result);
        }
    }

}