/*Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols.*/

using System;

namespace _11.NumberInDifferentFormat
{
    class NumberInDifferentFormat
    {
        static void Main()
        {

            Console.Write("enter a number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.Write("The number in decimal format is: {0,15:D}\n", (int)number);
            Console.Write("The number in hexademical format is: {0,15:X}\n", (int)number);
            Console.Write("The number in percentage is: {0,15:P}\n", number);
            Console.Write("The number in percentage is: {0,15:E}\n", number);
        }
    }
}
