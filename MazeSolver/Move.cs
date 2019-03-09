using System;
using System.Collections.Generic;

namespace MazeSolver
{
    public static class Move
    {

        public static int[] Up(int[] ActualPosition, char[,] Maze)
        {
            int pos_x = ActualPosition[0];
            int pos_y = ActualPosition[1];
            int newPos_x = pos_x - 1;
            int newPos_y = pos_y;

            return new int[] { newPos_x, newPos_y };
        }

        public static int[] Down(int[] ActualPosition, char[,] Maze)
        {
            int pos_x = ActualPosition[0];
            int pos_y = ActualPosition[1];
            int newPos_x = pos_x + 1;
            int newPos_y = pos_y;

            return new int[] { newPos_x, newPos_y };
        }

        public static int[] Right(int[] ActualPosition, char[,] Maze)
        {
            int pos_x = ActualPosition[0];
            int pos_y = ActualPosition[1];
            int newPos_x = pos_x;
            int newPos_y = pos_y + 1;

            return new int[] { newPos_x, newPos_y };
        }

        public static int[] Left(int[] ActualPosition, char[,] Maze)
        {
            int pos_x = ActualPosition[0];
            int pos_y = ActualPosition[1];
            int newPos_x = pos_x;
            int newPos_y = pos_y - 1;

            return new int[] { newPos_x, newPos_y };
        }
    }


}
