namespace Abstraction
{
    using System;
    using System.Collections.Generic;

    public class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            //Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", circle.Perimeter(), circle.Area());
            Rectangle rect = new Rectangle(2, 3);
            //Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", rect.Perimeter(), rect.Area());

            Console.WriteLine(circle.ToString());
            Console.WriteLine(rect.ToString());

            //not required for the homework
            List<IFigure> figures = new List<IFigure>();
            figures.Add(circle);
            figures.Add(rect);

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Area());
            }
        }
    }
}
