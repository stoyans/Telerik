/*Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Collections.Generic;

class HexademicalToBinaryDirectly
{
    static void Main()
    {
        Console.Write("Hexademical number: ");
        string hexNum = Console.ReadLine();

        Console.WriteLine(HexademicalToBinaryConvert(hexNum));
    }

    static string HexademicalToBinaryConvert(string hexNum)
    {
        string binaryvalue = null;
        binaryvalue = Convert.ToString(Convert.ToInt32(hexNum, 16), 2);

        return binaryvalue;
    }
}