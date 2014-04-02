using System;

namespace _4.Factorials
{
    class Factorials
    {
        static void Main()
        {
            Console.Write("value of K (K>1): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("value of N (N>K): ");
            int n = int.Parse(Console.ReadLine());
            int factorialK = 1;
            int factorialN = 1;
            //Calculationg K factorial
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            //Calculationg N factorial
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            Console.WriteLine("Result of N!/K! = {0}", factorialN/factorialK);
        }
    }
}
