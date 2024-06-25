using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class Maze
    {
        List<List<MazeTile>> mazeTiles;
        List<List<MazeTile>> newMazeTiles;

        private int count;
        public Maze(ContentManager Content)
        {
            mazeTiles = new List<List<MazeTile>>();

            for (var row = 0; row < 25; row++)
            {
                List<MazeTile> rowTiles = new List<MazeTile>();
                List<string> rowStrings = new List<string>();

                for (int element = 0; element < 25; element++)
                {
                    MazeTile tile = new MazeTile(Content, " ", new Rectangle(element * 20, row * 20, 20, 20));
                    string mazeString = " ";

                    rowTiles.Add(tile);
                    rowStrings.Add(mazeString);
                }
                mazeTiles.Add(rowTiles);
            }

        }

        private bool gameRunnung = false;
        private bool isTasking = false;
        public void Update(MouseState mouseState, KeyboardState keyboardState)
        {
            foreach (var i in mazeTiles)
            {
                foreach (var item in i)
                {
                    item.Update(mouseState, keyboardState, mazeTiles);
                }
            }

            // calculate final maze

            if (keyboardState.IsKeyDown(Keys.C) == true)
            {
                gameRunnung = true;
            }
            
            
            if (gameRunnung)
            {
                if (isTasking == false && count == 60)
                {
                    count = 0;
                    Task myTask = new Task(() =>
                    {
                        isTasking = true;
                        CalculateFinalMaze();
                        isTasking = false;
                    });
                    myTask.Start();
                }
                else
                {
                    count ++;
                }
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

        private void CalculateFinalMaze()
        {
            List<List<string>> myCalculatedMaze = new List<List<string>>();

            // Clean tiles
            newMazeTiles = mazeTiles.ToList();

            
            // Clean tiles
            for (var row = 0; row < newMazeTiles.Count; row++)
            {
                for (var element = 0; element < newMazeTiles.Count; element++)
                {
                    if (newMazeTiles[row][element].Name == "*")
                    {
                        newMazeTiles[row][element].Name = " ";
                    }
                }
            }
            
            

            for (var row = 0; row < newMazeTiles.Count; row++)
            {
                List<string> rows = new List<string>();
                foreach (var element in newMazeTiles[row])
                {
                    rows.Add(element.Name);
                }
                myCalculatedMaze.Add(rows);
            }

            var maze = new MazeSolver.Maze(myCalculatedMaze);
            MazeSolver.Tools.FillWithNumbers(maze);
            MazeSolver.Tools.GetShortestPath(maze);
            MazeSolver.Tools.CleanMaze(maze);
            MazeSolver.Tools.PrintMaze(maze);

            // update tiles
            for (var row = 0; row < newMazeTiles.Count; row++)
            {
                for (var element = 0; element < newMazeTiles.Count; element++)
                {
                    if (myCalculatedMaze[row][element] == "*")
                    {
                        newMazeTiles[row][element].Name = "*";
                    }
                }
            }

            mazeTiles = newMazeTiles.ToList();

        }
    }
}