using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Openaria
{
	public abstract class DrawableGameComponent
	{
		protected Texture2D sprite;
		protected bool active;
		protected Vector2 position;
		protected Rectangle drawRectangle;
		protected Vector2 origin;
		protected Color color;
		protected float scale;
		public DrawableGameComponent (ContentManager Content,String contentName,Vector2 position)
		{
			sprite = Content.Load<Texture2D>(contentName);

			drawRectangle = sprite.Bounds;
			active = true;


			this.scale = 1;
			color = Color.White;

			this.position = position;
			origin = new Vector2(drawRectangle.Center.X,drawRectangle.Center.Y);
		}

		public DrawableGameComponent (ContentManager Content,String contentName,Vector2 position,float scale,Color color)
		{
			sprite = Content.Load<Texture2D>(contentName);
			this.scale = scale;
			this.color = color;
			this.position = position;
			drawRectangle = sprite.Bounds;
			active = true;
			origin = new Vector2(drawRectangle.Center.X,drawRectangle.Center.Y);
		}

		abstract public void Update(GameTime gameTime);

		public virtual void Draw(SpriteBatch spriteb)
		{
			spriteb.Draw(sprite,position,drawRectangle,color,0f,origin,scale,SpriteEffects.None,0);
		}
	}
}

