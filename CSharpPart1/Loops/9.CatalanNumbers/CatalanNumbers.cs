using System;
using System.Numerics;

namespace _9.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("value for n (n>=0): ");
            uint n = uint.Parse(Console.ReadLine());
            BigInteger factorialn = 1;
            BigInteger factorial2n = 1;
            BigInteger sum = 0;

            for (uint i = 1; i <= n; i++)
            {
                factorialn *= i;
                if (i == n)
                {
                    factorial2n = factorialn;

                    for (uint k = n + 1; k <= 2 * n; k++)
                    {
                        factorial2n *= k;
                    }
                }
            }

            sum = factorial2n / ((factorialn * (n + 1)) * factorialn);

            Console.WriteLine(sum);

        }
    }
}