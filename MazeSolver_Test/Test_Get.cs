using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MazeSolver_Test
{


    //[TestFixture()]
    public class Test_Get
    {
        //[Test()]
        public void Test_Get_Up()
        {
            List<List<char>> maze = new List<List<char>>
            {
                new List<char>() { ' ', ' ', ' ', ' ', 'x' },
                new List<char>() { ' ', ' ', ' ', ' ', ' ' },
                new List<char>() { 'x', ' ', 's', ' ', ' ' },
                new List<char>() { ' ', ' ', 'x', ' ', ' ' },
                new List<char>() { ' ', ' ', ' ', ' ', ' ' },
                new List<char>() { ' ', ' ', 'x', ' ', 'e' }
            };

            List<List<char>> mazeExpected = new List<List<char>>
            {
                new List<char>() { '4', '3', '2', '3', 'x' },
                new List<char>() { '3', '2', '1', '2', '3' },
                new List<char>() { 'x', '1', 's', '1', '2' },
                new List<char>() { '3', '2', 'x', '2', '3' },
                new List<char>() { '4', '3', '4', '3', '4' },
                new List<char>() { '5', '4', 'x', '4', 'e' }
            };
        }

    }
}
