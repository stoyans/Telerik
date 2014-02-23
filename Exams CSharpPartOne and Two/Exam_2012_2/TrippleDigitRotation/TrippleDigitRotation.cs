using System;

namespace TrippleDigitRotation
{
    class TrippleDigitRotation
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int[] array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int lastdigit = num % 10;
                num /= 10;

                if (lastdigit == 0)
                {
                    continue;
                }

                array[i] = lastdigit;
            }

            if (n > 9 && n < 100)
            {
                for (int i = 0; i <= 1; i++)
                {
                    Console.Write(array[i]);
                    if (i == 1)
                    {
                        Console.WriteLine();
                    }

                }
            }
            else
            {
                for (int i = 2; i >= 0; i--)
                {
                    if (array[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(array[i]);
                    if (i == 0 && num == 0)
                    {
                        Console.WriteLine();
                    }

                }
                if (num != 0)
                {
                    Console.WriteLine(num);
                }
            }
            
        }
    }
}
