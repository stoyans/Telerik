using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            //С няколко условни оператора проверяваме дали дискриминантата е < > или = 0, след което намириме и корените на уравнението
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double root2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("The roots of the equation are {0:F2} and {1:F2}", root1, root2);
            }
            else if (discriminant == 0)
            {
                int root = -b / 2 * a;
                Console.WriteLine("The only root of the equation is: {0:F2}", root);
            }
            else
            {
                Console.WriteLine("Thera are no real roots");
            }

        }
    }
}
