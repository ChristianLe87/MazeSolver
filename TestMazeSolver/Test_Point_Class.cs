using System;
using System.Collections.Generic;
using Main_Maze_Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMazeSolver
{
    [TestClass]
    public class Test_Point_Class
    {
        [TestMethod]
        public void Test_Point()
        {
            var point = new Point(0, 0);
            Assert.IsTrue(point.X == 0 && point.Y == 0);
        }


        [TestMethod]
        public void Test_Point_Up()
        {
            var point = new Point(0, 0);
            Assert.IsTrue(point.Up.X == 0 && point.Up.Y == -1);
        }


        [TestMethod]
        public void Test_Point_Down()
        {
            var point = new Point(0, 0);
            Assert.IsTrue(point.Down.X == 0 && point.Down.Y == 1);
        }


        [TestMethod]
        public void Test_Point_Right()
        {
            var point = new Point(0, 0);
            Assert.IsTrue(point.Right.X == 1 && point.Right.Y == 0);
        }


        [TestMethod]
        public void Test_Point_Left()
        {
            var point = new Point(0, 0);
            Assert.IsTrue(point.Left.X == -1 && point.Left.Y == 0);
        }
    }
}