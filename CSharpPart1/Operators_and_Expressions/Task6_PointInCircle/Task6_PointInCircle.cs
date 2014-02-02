using System;

namespace Task6_PointInCircle
{
    class Task6_PointInCircle
    {
        static void Main()
        {

            Console.Write("Enter a value for x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for y: ");
            int y = int.Parse(Console.ReadLine());
            //Методът Math.Pow повдига на степен, а условието е изпълнено, когато x^2 + y^2 < radius^2
            if (Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(5, 2))
            {
                Console.WriteLine("The points are inside the circle");
            }
            else
            {
                Console.WriteLine("The points are outside or on the line of the circle");
            }
        }
    }
}
