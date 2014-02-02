using System;

namespace _5.Multiply_Factorials
{
    class Multiply_Factorials
    {
        static void Main()
        {
            Console.Write("value of N (N>1): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("value of K (K>N): ");
            int k = int.Parse(Console.ReadLine());
            
            int factorialK = 1;
            int factorialN = 1;
            int factorialKN = 1;

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
            for (int i = 1; i <= k-n; i++)
            {
                factorialKN *= i;
            }

            int result = (factorialN * factorialK) / factorialKN;
            Console.WriteLine("The result of N!*K!/(K-N)! = {0}", result);
        }
    }
}
