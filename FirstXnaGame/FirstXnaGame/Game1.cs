﻿using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace FirstXnaGame
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		// teddy bear drawings support
		Texture2D bear0;
		Rectangle rectangle0;
		Texture2D bear1;
		Rectangle rectangle1;
		Texture2D bear2;
		Rectangle rectangle2;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			// change resolution to 800 x 600
			graphics.PreferredBackBufferWidth = 800;
			graphics.PreferredBackBufferHeight = 600;
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

			// load teddy bears and build draw rectangles
			bear0 = Content.Load<Texture2D>(System.IO.Path.Combine("graphics", "teddybear0"));
			rectangle0 = new Rectangle(150, 100, bear0.Width, bear0.Height);

			bear1 = Content.Load<Texture2D>(System.IO.Path.Combine("graphics", "teddybear1"));
			rectangle1 = new Rectangle(300, 100, bear0.Width, bear0.Height);

			bear2 = Content.Load<Texture2D>(System.IO.Path.Combine("graphics", "teddybear2"));
			rectangle2 = new Rectangle(450, 100, bear0.Width, bear0.Height);
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
#if !__IOS__ && !__TVOS__
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();
#endif

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			// draw teddy bears
			spriteBatch.Begin();

			spriteBatch.Draw(bear0, rectangle0, Color.White);
			spriteBatch.Draw(bear1, rectangle1, Color.White);
			spriteBatch.Draw(bear2, rectangle2, Color.White);

			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

