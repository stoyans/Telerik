using System;

namespace Task10_Return_if_bit_is_1
{
    class Task10_Return_if_bit_is_1
    {
        static void Main()
        {
            //The task is similar to task 5

            Console.Write("Enter position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number: ");
            int v = int.Parse(Console.ReadLine());

            int bit = v & (1 << p);

            Console.WriteLine(bit == 0 ? false : true);

        }
    }
}
