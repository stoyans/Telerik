/*Write a program to convert from any numeral system of 
 * given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Collections.Generic;

class ConvertToAnyNumeralSystem
{
    static void Main()
    {
        Console.Write("Choose a numeral system to convert FROM: ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("value of the number: ");
        string number = Console.ReadLine();
        Console.Write("Choose a numeral system to convert TO: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine(BaseStoDecimal(number, s, d));

    }

    static string BaseStoDecimal(string num, int s, int d)
    {
        int numToDecimal = 0;

        for (int i = num.Length - 1; i >= 0; i--)
        {
            int power = Convert.ToInt32(Math.Pow(s, num.Length - 1 - i));
            char symbol = num[i];
            symbol = Char.ToUpper(symbol);

            if (symbol >= 'A' && symbol <= 'F')
            {
                switch (symbol)
                {
                    case 'A': numToDecimal += power * 10;
                        break;
                    case 'B': numToDecimal += power * 11;
                        break;
                    case 'C': numToDecimal += power * 12;
                        break;
                    case 'D': numToDecimal += power * 13;
                        break;
                    case 'E': numToDecimal += power * 14;
                        break;
                    case 'F': numToDecimal += power * 15;
                        break;
                }
            }
            else
            {
                int digit = num[i] - 48;
                numToDecimal += power * digit;
            }
        }

        return DecimalToDBase(numToDecimal, d);
    }

    static string DecimalToDBase(int decimalNum, int d)
    {

        string numToDBase = string.Empty;
        int digit;

        while (decimalNum > 0)
        {
            digit = decimalNum % d;

            if (digit > 9 && digit < 16)
            {
                switch (digit)
                {
                    case 10: numToDBase = 'A' + numToDBase;
                        break;
                    case 11: numToDBase = 'B' + numToDBase;
                        break;
                    case 12: numToDBase = 'C' + numToDBase;
                        break;
                    case 13: numToDBase = 'D' + numToDBase;
                        break;
                    case 14: numToDBase = 'E' + numToDBase;
                        break;
                    case 15: numToDBase = 'F' + numToDBase;
                        break;
                }
            }
            else
            {
                numToDBase = digit + numToDBase;
            }

            decimalNum /= d;
        }

        return numToDBase;
    }
}