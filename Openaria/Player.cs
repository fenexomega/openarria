using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Openaria
{
	public class Player : DrawableGameComponent
	{
		int heathPoints;
		int maxHeathPoints;
		int manaPoints;
		int maxManaPoints;


		public Player (ContentManager Content,String contentName,Vector2 position) : base(Content,contentName,position)
		{
			this.heathPoints = 100;
			this.maxHeathPoints = 100;

			this.manaPoints = 0;
			this.maxManaPoints = 20;

		}

		public override void Update(GameTime gametime)
		{

		}

		public override void Draw (SpriteBatch spriteb)
		{
			base.Draw(spriteb);
		}

	}
}

