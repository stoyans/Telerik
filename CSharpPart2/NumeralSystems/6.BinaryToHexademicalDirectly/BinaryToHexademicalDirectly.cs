/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Collections.Generic;

class BinaryToHexademicalDirectly
{
    static void Main()
    {
        Console.Write("binary number: ");
        string binaryNum = Console.ReadLine();

        Console.WriteLine(BinaryToHexademicalConvert(binaryNum));
    }

    static string BinaryToHexademicalConvert(string binaryNum)
    {
        string numToHex = string.Empty;

        binaryNum = binaryNum.PadLeft(32, '0');

        for (int i = 0; i < binaryNum.Length - 3; i += 4)
        {
            string firstBit = Convert.ToString(binaryNum[i] - 48);
            string secondBit = Convert.ToString(binaryNum[i + 1] - 48);
            string thirdBit = Convert.ToString(binaryNum[i + 2] - 48);
            string fourthBit = Convert.ToString(binaryNum[i + 3] - 48);

            string setofBits4 = firstBit + secondBit + thirdBit + fourthBit;

            switch (setofBits4)
            {
                case "0001":
                    numToHex += "1";
                    break;
                case "0010":
                    numToHex += "2";
                    break;
                case "0011":
                    numToHex += "3";
                    break;
                case "0100":
                    numToHex += "4";
                    break;
                case "0101":
                    numToHex += "5";
                    break;
                case "0110":
                    numToHex += "6";
                    break;
                case "0111":
                    numToHex += "7";
                    break;
                case "1000":
                    numToHex += "8";
                    break;
                case "1001":
                    numToHex += "9";
                    break;
                case "1010":
                    numToHex += "A";
                    break;
                case "1011":
                    numToHex += "B";
                    break;
                case "1100":
                    numToHex += "C";
                    break;
                case "1101":
                    numToHex += "D";
                    break;
                case "1110":
                    numToHex += "E";
                    break;
                case "1111":
                    numToHex += "F";
                    break;
            }
        }

        return numToHex;
    }
}