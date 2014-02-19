using System;

namespace Shapes
{
    class MainClass
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(4, 5);
            Console.WriteLine(triangle.CalculateSurface());
            var rectangle = new Rectangle(3, 5);
            Console.WriteLine(rectangle.CalculateSurface());
            var circle = new Circle(4);
            Console.WriteLine("{0:F2}", circle.CalculateSurface());

        }
    }
}
