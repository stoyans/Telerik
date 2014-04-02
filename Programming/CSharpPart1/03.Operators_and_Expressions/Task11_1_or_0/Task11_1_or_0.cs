using System;

namespace Task11_1_or_0
{
    class Task11_1_or_0
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter position of the bit: ");
            int b = int.Parse(Console.ReadLine());

            int bit = i & (1 << b);

            Console.WriteLine(bit == 0 ? 0 : 1);
        }
    }
}
