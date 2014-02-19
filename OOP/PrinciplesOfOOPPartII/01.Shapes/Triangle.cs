using System;

namespace Shapes
{
    public class Triangle : Rectangle
    {
        public Triangle(int height, int width)
            : base(height, width)
        {

        }

        public override decimal CalculateSurface()
        {
            return (Height * Width / 2);
        }
    }
}

