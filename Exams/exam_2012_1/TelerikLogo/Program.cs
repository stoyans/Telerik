using System;

namespace TelerikLogo
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = x / 2 + 1;

            for (int i = 1; i <= 3 * x - 2; i++)
            {
                for (int k = 1; k <= 3 * x - 2; k++)
                {
                    if ((i >= 2 * y && (k == z + 1 + i - 2 * y || k == 3 * x - z - 2 - i + 2 * y)) || ((k == z - 1 + i || k == z + 1 - i || k == 3 * x - 2 - z + i || k == 3 * x - z - i) && i < 2 * y))
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
