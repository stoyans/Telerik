using System;

namespace _12.Matrix
{
    class Matrix
    {
        static void Main()
        {
            Console.Write("value for n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = i; k < n+i; k++)
                {
                    Console.Write("{0,2}",k);
                }
                Console.WriteLine();
            }
        }
    }
}
