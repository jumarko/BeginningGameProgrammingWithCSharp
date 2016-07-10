using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ExplodingTeddies;

namespace Week3Lab10
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		const int WindowWidth = 800;
		const int WindowHeight = 600;

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		TeddyBear teddyBear0;
		TeddyBear teddyBear1;
		Explosion explosion;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			graphics.PreferredBackBufferWidth = WindowWidth;
			graphics.PreferredBackBufferHeight = WindowHeight;
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

			teddyBear0 = new TeddyBear(Content, WindowWidth, WindowHeight, @"graphics\teddybear0", 50, 200,
			                           new Vector2(0.1f, 0.0f));
			teddyBear1 = new TeddyBear(Content, WindowWidth, WindowHeight, @"graphics\teddybear1", 350, 200,
			                          new Vector2(-0.2f, 0.0f));
			explosion = new Explosion(Content, @"graphics\explosion");
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


			teddyBear0.Update(gameTime);
			teddyBear1.Update(gameTime);

			// detect collision
			Rectangle intersection = Rectangle.Intersect(teddyBear0.DrawRectangle, teddyBear1.DrawRectangle);
			if (intersection.Width > 0) 
			{
				explosion.Play(intersection.X, intersection.Y);
				teddyBear0.Active = false;
				teddyBear1.Active = false;
			}

			explosion.Update(gameTime);

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin();

			teddyBear0.Draw(spriteBatch);
			teddyBear1.Draw(spriteBatch);
			explosion.Draw(spriteBatch);

			spriteBatch.End();


			base.Draw(gameTime);
		}
	}
}

