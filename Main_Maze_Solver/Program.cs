using System;

namespace Main_Maze_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            var maze = new char[,] {
            { 's', '*', '*',},
            { '*', 'x', '*',},
            { '*', '*', 'e', }
            };

            int[] actual_Position = new int[] { 1, 1 };



            Implementation(maze);

            Console.WriteLine("--- end ---");
            Console.ReadKey();
        }

        public static void Implementation(char[,] myMaze)
        {
            /*
            if (!isMazeAsExpected.isExpectedCharacters(myMaze))
                throw new ArgumentException(errorMessage_InvalidCharactes);

            if (!isMazeAsExpected.isOneStart(myMaze))
                throw new ArgumentException(errorMessage_MoreStartChars);

            if (!isMazeAsExpected.isOneEnd(myMaze))
                throw new ArgumentException(errorMessage_MoreEndChars);
            */


            //Maze.printUpdatedMaze(myMaze);
            //Console.WriteLine();

            //int[] ActualPosition = get.getPointStart(myMaze);
            //List<int[]> LastPosition = new List<int[]>();
            //LastPosition.Add(get.getPointStart(myMaze));
            //int[] start = get.getPointStart(myMaze);
            //int[] end = get.getPointEnd(myMaze);
            //string[] myCompas = Compas.Update(start, end);
            //bool foundEnd = false;
            ////List<int[]> logPositions = new List<int[]>();

            //myMaze = Maze.DeleteDeadEnds(myMaze);
            //Maze.printUpdatedMaze(myMaze);
            //Console.WriteLine();

            ////logPositions.Add(start);
            //while (!foundEnd)
            //{
            //    // update compas
            //    //myCompas = Compas.Update(start, end);

            //    // save actual step into previeus step
            //    LastPosition.Add(ActualPosition);//Position.updateLastPointPosition();

            //    // move
            //    ActualPosition = Position.moveToNewPosition(myCompas, ActualPosition, LastPosition, myMaze, end);
            //    if (ActualPosition[0] > 0 || ActualPosition[1] > 0)
            //        myMaze[ActualPosition[0], ActualPosition[1]] = myMaze[ActualPosition[0], ActualPosition[1]] == 'e' ? 'e' : ',';

            //    // log position
            //    //logPositions.Add(ActualPosition);

            //    //read if im in end
            //    foundEnd = get.getFoundEnd(ActualPosition, end);
            //}
            ////logPositions.Add(end);
            //if (!foundDeadEnd)
            //    Maze.printUpdatedMaze(myMaze);
            //else
            //    Console.WriteLine("Maze without solution");

        }
    }
}
