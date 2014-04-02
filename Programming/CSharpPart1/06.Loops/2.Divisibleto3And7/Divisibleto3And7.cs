using System;

namespace _2.Divisibleto3And7
{
    class Divisibleto3And7
    {
        static void Main()
        {
            Console.Write("value of N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
