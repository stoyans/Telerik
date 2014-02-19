using System;

namespace Shapes
{
    public class Circle : Triangle
    {
        public Circle(int radius)
            : base(radius, radius)
        {

        }

        public override decimal CalculateSurface()
        {
            return (decimal)(Math.PI * Height * Height);
        }
    }

}

