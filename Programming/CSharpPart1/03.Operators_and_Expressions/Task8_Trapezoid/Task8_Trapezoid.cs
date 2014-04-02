using System;

namespace Task8_Trapezoid
{
    class Task8_Trapezoid
    {
        static void Main()
        {
            Console.Write("Give value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Give value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Give value for h: ");
            double h = double.Parse(Console.ReadLine());

            double area = (((a + b) / 2) * h);
            Console.WriteLine("Area of the trapezoid is: {0}", area);
        }
    }
}
