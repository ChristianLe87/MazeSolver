﻿using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_MazeSolver_MacOS
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        double timeCount = 0;
        int delay = 1;
        string[,] myMaze = new string[,]
            {
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", "x", "x", " ", "x", "x", " ", "x", " " },
                { " ", " ", " ", " ", "x", " ", " ", "x", " " },
                { " ", " ", "x", " ", "x", " ", " ", "x", " " },
                { " ", "s", "x", " ", " ", " ", " ", "x", "e" }
            };
        Maze maze;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            int mazeWide = myMaze.GetLength(1);
            int mazeHeigh = myMaze.GetLength(0);

            graphics.PreferredBackBufferWidth = mazeWide * 20;
            graphics.PreferredBackBufferHeight = mazeHeigh * 20;
        }


        protected override void Initialize()
        {
            base.Initialize();
            this.IsMouseVisible = true;
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            maze = new Maze(myMaze, Content);
        }


        protected override void Update(GameTime gameTime)
        {
            // For Mobile devices, this logic will close the Game when the Back button is pressed
            // Exit() is obsolete on iOS
            /*#if !__IOS__ && !__TVOS__
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();
            #endif*/

            MouseState state = Mouse.GetState();


            // Maze solver
            {
                Tools.FillWithNumbers(maze);
                Tools.GetShortestPath(maze);
                Tools.CleanMaze(maze);
                //Tools.PrintMaze(maze);
            }

            base.Update(gameTime);
        }



        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            maze.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}