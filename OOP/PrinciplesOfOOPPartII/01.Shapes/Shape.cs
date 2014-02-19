using System;

namespace Shapes
{
    public abstract class Shape
    {

        public Shape(int height, int widht)
        {
            this.Height = height;
            this.Width = widht;
        }

        public int Height
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public virtual decimal CalculateSurface()
        {
            return Height * Width;
        }
    }
}
