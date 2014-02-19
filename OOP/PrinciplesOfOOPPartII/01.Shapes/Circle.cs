using System;

namespace Shapes
{
    public class Circle : Shape
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

