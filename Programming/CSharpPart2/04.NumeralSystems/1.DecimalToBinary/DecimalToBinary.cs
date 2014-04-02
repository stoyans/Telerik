/*Write a program to convert decimal numbers to their binary representation.*/

using System;
using System.Collections.Generic;

namespace _1.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("decimal number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ToBinary(number));
        }

        static string ToBinary(int num)
        {
            string numToBinary = null;
            int bit;

            while (num > 0)
            {
                bit = num % 2;
                num /= 2;
                numToBinary = bit + numToBinary;
            }

            return numToBinary;
        }
    }
}
