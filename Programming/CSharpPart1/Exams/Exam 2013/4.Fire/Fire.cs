using System;

namespace _4.Fire
{
    class Fire
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - n / 4; i++)
            {

                for (int k = 1; k <= n; k++)
                {
                    if (k == n / 2 + 1 - i || k == n / 2 + i)
                    {
                        Console.Write('#');
                    }
                    else if ((i >= n / 2 + 1 && (k == n + n / 2 + 1 - i || k == i - n / 2)))
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }

                }
                Console.WriteLine();
            }

            for (int i1 = 1; i1 <= n; i1++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            for (int i = 1; i <= n / 2; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if ((k <= n / 2 && k >= i))
                    {
                        Console.Write('\\');
                    }
                    else if ((k < n - i + 2 && k >= n / 2 + 1))
                    {
                        Console.Write('/');
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
