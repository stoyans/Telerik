/*Write a program that shows the binary representation of 
 * given 16-bit signed integer number (the C# type short).*/

using System;
using System.Collections.Generic;

class BinaryOf16BitSigned
{
    static void Main()
    {
        Console.Write("enter a value of negative short number: ");
        short num = short.Parse(Console.ReadLine());

        Console.WriteLine(ConvertToBinary(num));

        Console.WriteLine();
        Console.WriteLine(ConvertToBinaryLongWay(num));

    }
    // easy way
    static string ConvertToBinary(short number)
    {
        string numToBinary = Convert.ToString(number, 2).PadLeft(16, '0');
        return numToBinary;
    }
    // hard way. Info at: http://visualcsharptutorials.com/reference/converting-negative-numbers-to-binary
    static string ConvertToBinaryLongWay(short number)
    {
        number = Math.Abs(number);
        int carry = 0;
        string negativeInBinary = string.Empty;
        string numTo2Base = string.Empty;

        int digit;

        // ~number in binary
        while (number > 0)
        {
            digit = number % 2;

            if (digit == 1)
            {
                numTo2Base = 0 + numTo2Base;
            }
            else
            {
                numTo2Base = 1 + numTo2Base;
            }

            number /= 2;
        }

        numTo2Base = numTo2Base.PadLeft(16, '1');
        string numOne = "1".PadLeft(16, '0');
        //sum numTo2Base + numOne
        for (int i = numTo2Base.Length - 1; i >= 0; i--)
        {
            int sum = (numTo2Base[i] - 48) + (numOne[i] - 48);

            if (sum + carry == 2)
            {
                negativeInBinary = 0 + negativeInBinary;
                carry = 1;
            }
            else if (sum + carry == 3)
            {
                negativeInBinary = 1 + negativeInBinary;
                carry = 1;
            }
            else
            {
                negativeInBinary = (sum + carry) + negativeInBinary;
                carry = 0;
            }

        }

        return negativeInBinary;
    }
}