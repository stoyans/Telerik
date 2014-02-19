using System;

namespace Shapes
{
    public class Rectangle : Shape
    {

        public Rectangle(int height, int widht)
            : base(height, widht)
        {

        }

        public override decimal CalculateSurface()
        {
            return (Height * Width);
        }

    }
}

