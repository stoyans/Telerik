using System;
using System.Numerics;

namespace _7.FibonacciSum
{
    class FibonacciSum
    {
        static void Main()
        {
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger next;
            BigInteger sum = 1;

            Console.Write("Value of n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                next = first + second;
                first = second;
                second = next;
                sum += next;
            }

            Console.WriteLine("Sum of first N members is: {0}", sum);
        }
    }
}
