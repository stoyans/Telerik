using System;
using System.Collections.Generic;

namespace _05.BitArray64
{
    class Program
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(20);
            BitArray64 number2 = new BitArray64(7);

            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine("Bit at position 2 is {0}", number[2]);

            Console.WriteLine("Hash code of {0} is {1}", number.Number, number.GetHashCode());

            Console.WriteLine("number == number2 -> {0}", number == number2);
            Console.WriteLine("number != number2 -> {0}", number != number2);
            Console.WriteLine("number equals number2 -> {0}", number.Equals(number2));
        }
    }
}
