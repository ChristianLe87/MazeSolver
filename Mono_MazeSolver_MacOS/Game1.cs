using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_MazeSolver_MacOS
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D pathTexture;
        Texture2D startTexture;
        Texture2D endTexture;
        Texture2D wallTexture;
        Texture2D notWallTexture;

        string[,] myMaze = new string[,]
            {
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", " ", " ", " ", "x", " ", " ", " ", " " },
                { " ", "x", "x", " ", " ", " ", " ", "x", " " },
                { " ", "s", " ", "x", "x", " ", " ", "x", " " },
                { " ", " ", "x", " ", " ", " ", " ", "x", " " },
                { " ", " ", "x", " ", " ", " ", " ", "x", "e" }
            };
        Maze maze;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 500;
            graphics.PreferredBackBufferHeight = 500;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            maze = new Maze(myMaze, Content);
            //TODO: use this.Content to load your game content here 
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // For Mobile devices, this logic will close the Game when the Back button is pressed
            // Exit() is obsolete on iOS
            #if !__IOS__ &&  !__TVOS__
            if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) 
                Exit ();
            #endif
            
            // TODO: Add your update logic here
            
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
