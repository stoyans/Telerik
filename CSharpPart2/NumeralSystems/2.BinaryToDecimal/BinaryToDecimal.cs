/*Write a program to convert binary numbers to their decimal representation.*/

using System;
using System.Collections.Generic;

namespace _2.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("binary number: ");
            string binaryNum = Console.ReadLine();

            Console.WriteLine(BinaryToDecimalConvert(binaryNum));
        }

        static int BinaryToDecimalConvert(string binary)
        {
            int numToDecimal = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int power = Convert.ToInt32(Math.Pow(2, binary.Length - 1 - i));
                int bit = binary[i]-48;

                numToDecimal += power*bit;
            }

            return numToDecimal;
        }
    }
}
