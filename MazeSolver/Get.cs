using System;
namespace MazeSolver
{
    public static class Get
    {

        public static char Up(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int whereToRead_x = ActualPosition[0] - 1;
            int whereToRead_y = ActualPosition[1];

            if (whereToRead_x < 0)
                result = 'x';
            else
                result = myMaze[whereToRead_x, whereToRead_y];

            return result; // x * s e
        }

        public static char Down(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int whereToRead_x = ActualPosition[0] + 1;
            int whereToRead_y = ActualPosition[1];

            if (whereToRead_x > (myMaze.GetLength(0) - 1))
                result = 'x';
            else
                result = myMaze[whereToRead_x, whereToRead_y];

            return result; // x * s e
        }

        public static char Right(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0];
            int read_y = ActualPosition[1] + 1;

            if (read_y > (myMaze.GetLength(1) - 1))
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

        public static char Left(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0];
            int read_y = ActualPosition[1] - 1;

            if (read_y < 0)
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

        public static char UpLeft(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0] - 1;
            int read_y = ActualPosition[1] - 1;

            if (read_y < 0)
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

        public static char UpRight(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0] - 1;
            int read_y = ActualPosition[1] + 1;

            if (read_y > (myMaze.GetLength(1) - 1))
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

        public static char DownLeft(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0] + 1;
            int read_y = ActualPosition[1] - 1;

            if (read_y < 0)
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

        public static char DownRight(int[] ActualPosition, char[,] myMaze)
        {
            char result = ' ';
            int read_x = ActualPosition[0] + 1;
            int read_y = ActualPosition[1] + 1;

            if (read_y > (myMaze.GetLength(1) - 1))
                result = 'x';
            else
                result = myMaze[read_x, read_y];

            return result; // x * s e
        }

    }

}