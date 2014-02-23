using System;
using System.Numerics;

namespace _13.TrailingZeroOfN_
{
    class TrailingZeroOfN
    {
        static void Main()
        {
            //Explanation at http://www.introprogramming.info/intro-csharp-book/read-online/glava6-cikli/ task 11

            Console.Write("value of n: ");
            int n = int.Parse(Console.ReadLine());
            uint count = 0;
            BigInteger factorial = 1;

            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            while (factorial % 10 == 0)
            {
                count++;
                factorial /= 10;
            }

            Console.WriteLine("The trailing zeros of N! are(is): {0}",count);

        }
    }
}
