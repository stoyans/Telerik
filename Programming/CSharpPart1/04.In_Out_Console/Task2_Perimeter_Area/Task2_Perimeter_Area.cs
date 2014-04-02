using System;

namespace Task2_Perimeter_Area
{
    class Task2_Perimeter_Area
    {
        static void Main()
        {
            Console.Write("Enter circle's radius: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The perimeter of the cirle is {0:F3} and the area is {1:F3}", perimeter, area);
        }
    }
}
