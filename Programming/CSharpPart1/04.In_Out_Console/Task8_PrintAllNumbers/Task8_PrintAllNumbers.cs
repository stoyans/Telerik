using System;

namespace Task8_PrintAllNumbers
{
    class Task8_PrintAllNumbers
    {
        static void Main()
        {
            Console.Write("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
