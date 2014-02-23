using System;

namespace _6.CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            Console.Write("value of N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("value of X: ");
            double x = double.Parse(Console.ReadLine());

            int factorialN = 1;
            double powerX = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                powerX *= x;
                sum += factorialN / x;
            }
            
            Console.WriteLine("The sum = {0}", sum);
        }
    }
}
