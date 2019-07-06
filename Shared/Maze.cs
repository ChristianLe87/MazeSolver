using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class Maze
    {
        List<List<MazeTile>> mazeTiles;
        bool canDrawMaze = false;
        public Maze(ContentManager Content)
        {
            mazeTiles = new List<List<MazeTile>>();

            for (var row = 0; row < 23; row++)
            {
                List<MazeTile> rowTiles = new List<MazeTile>();
                List<string> rowStrings = new List<string>();

                for (int element = 0; element < 25; element++)
                {
                    MazeTile tile = new MazeTile(Content, " ", new Rectangle(element * 20, 40 + row * 20, 20, 20));
                    string mazeString = " ";

                    rowTiles.Add(tile);
                    rowStrings.Add(mazeString);
                }
                mazeTiles.Add(rowTiles);
            }

        }


        public void Update(MouseState mouseState, KeyboardState keyboardState)
        {
            foreach (var i in mazeTiles)
            {
                foreach (var item in i)
                {
                    item.Update(mouseState, keyboardState, mazeTiles);
                }
            }




            List<List<string>> myMaze = new List<List<string>>();


            for (var row = 0; row < mazeTiles.Count; row++)
            {
                List<string> rows = new List<string>();
                foreach (var element in mazeTiles[row])
                {
                    rows.Add(element.Name);
                }
                myMaze.Add(rows);
            }


            




            if ((keyboardState.IsKeyDown(Keys.P) == true))
            {
                canDrawMaze = true;
                
            }

            if (canDrawMaze)
            {
                var maze = new MazeSolver.Maze(myMaze);
                MazeSolver.Tools.FillWithNumbers(maze);
                MazeSolver.Tools.GetShortestPath(maze);
                MazeSolver.Tools.CleanMaze(maze);
                MazeSolver.Tools.PrintMaze(maze);
            }


        }



        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var i in mazeTiles)
            {
                foreach (var item in i)
                {
                    item.Draw(spriteBatch);
                }
            }
        }
    }
}