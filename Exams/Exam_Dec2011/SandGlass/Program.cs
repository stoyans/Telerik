using System;

namespace SandGlass
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n/2+1; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (k >= i && k <= n + 1 - i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n/2; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (k >= n / 2 + 1 - i && k <= n / 2 + 1 + i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
