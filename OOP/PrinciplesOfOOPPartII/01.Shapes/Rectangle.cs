using System;

namespace Shapes
{
	public class Rectangle : Shape
	{
		private int height;
		private int width;
		
		public Rectangle (int height, int widht)
		{
			this.Height = height;
			this.Width = widht;
		}
		
		public int Height
		{
			get; set;
		}
		
		public int Width
		{
			get; set;
		}
		
		public override decimal CalculateSurface()
		{
			return (Height*Width);
		}
		
	}
}

