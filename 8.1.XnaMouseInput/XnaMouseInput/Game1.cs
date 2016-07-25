﻿#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

#endregion

namespace XnaMouseInput
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		const int WindowWidth = 800;
		const int WindowHeight = 600;

		// drawing support
		Texture2D currentCharacter;
		Rectangle drawRectangle;

		// random character support
		Random rand = new Random();
		// array for lesson 9.1
		Texture2D[] characters = new Texture2D[4];
		//Texture2D character0;
		//Texture2D character1;
		//Texture2D character2;
		//Texture2D character3;

		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	            

			// set resolution and make mouse visible
			graphics.PreferredBackBufferWidth = WindowWidth;
			graphics.PreferredBackBufferHeight = WindowHeight;
			IsMouseVisible = true;	
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			// TODO: Add your initialization logic here
			base.Initialize ();
				
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

			// load character sprites
			//character0 = Content.Load<Texture2D>(@"graphics\character0");
			//character1 = Content.Load<Texture2D>(@"graphics\character1");
			//character2 = Content.Load<Texture2D>(@"graphics\character2");
			//character3 = Content.Load<Texture2D>(@"graphics\character3");

			// array for Lesson 9.1
			characters[0] = Content.Load<Texture2D>(@"graphics\character0");
			characters[1] = Content.Load<Texture2D>(@"graphics\character1");
			characters[2] = Content.Load<Texture2D>(@"graphics\character2");
			characters[3] = Content.Load<Texture2D>(@"graphics\character3");

			// start character 0 in center of window
			currentCharacter = characters[0];
			drawRectangle = new Rectangle(WindowWidth / 2 - currentCharacter.Width / 2,
				WindowHeight / 2 - currentCharacter.Height / 2,
				currentCharacter.Width, currentCharacter.Height);
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed
			// Exit() is obsolete on iOS
			#if !__IOS__
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
			    Keyboard.GetState ().IsKeyDown (Keys.Escape)) {
				Exit ();
			}
#endif

			// make character follow mouse
			MouseState mouse = Mouse.GetState();
			drawRectangle.X = mouse.X - currentCharacter.Width / 2;
			drawRectangle.Y = mouse.Y - currentCharacter.Height / 2;

			// clamp character in window
			if (drawRectangle.Left < 0)
			{
				drawRectangle.X = 0;
			}
			if (drawRectangle.Right > WindowWidth)
			{
				drawRectangle.X = WindowWidth - drawRectangle.Width;
			}
			if (drawRectangle.Top < 0)
			{
				drawRectangle.Y = 0;
			}
			if (drawRectangle.Bottom > WindowHeight)
			{
				drawRectangle.Y = WindowHeight - drawRectangle.Height;
			}


			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.CornflowerBlue);

			// draw character
			spriteBatch.Begin();
			spriteBatch.Draw(currentCharacter, drawRectangle, Color.White);
			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
