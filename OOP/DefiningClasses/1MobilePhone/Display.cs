using System;

namespace MobilePhone
{
	public class Display
	{
		private int sizeInInch;
		private int numberOfColors;

		public Display(int size, int colors)
		{
			this.DisplaySize = size;
			this.NumberOfColors = colors;
		}
		
		public int DisplaySize
		{
			get
			{
				return this.sizeInInch;
			}
			set
			{
				if (value < 0) 
				{
					throw new ArgumentOutOfRangeException("The size of the display must be > 0!");	
				}
				this.sizeInInch = value;
			}
		}
		
		public int NumberOfColors
		{
			get
			{
				return this.numberOfColors;
			}
			set
			{
				if (value < 0) 
				{
					throw new ArgumentOutOfRangeException("The colors can Not be negative!");
				}
				this.numberOfColors = value;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("Display has {0}M colors and the size is {1} inches",
			                      numberOfColors, sizeInInch);
		}
		
	}
}

