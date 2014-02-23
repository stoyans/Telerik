using System;

namespace _3.MinAndMax
{
    class MinAndMax
    {
        static void Main()
        {
            Console.Write("value of N: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Biggest number is: {0}\nSmallest is: {1}", max, min);
        }
    }
}
