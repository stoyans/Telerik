/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;

namespace _3.DecimalToHexademical
{
    class DecimalToHexademical
    {
        static void Main()
        {
            Console.WriteLine("decimal number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ToHexademical(number));
        }

        static string ToHexademical(int num)
        {
            string numToHexademical = null;
            int hex;

            while (num > 0)
            {
                hex = num % 16;

                if (hex > 9)
	            {
		            switch (hex)
	                {
                        case 10: numToHexademical = "A" + numToHexademical;
                            break;
                        case 11: numToHexademical = "B" + numToHexademical;
                            break;
                        case 12: numToHexademical = "C" + numToHexademical;
                            break;
                        case 13: numToHexademical = "D" + numToHexademical;
                            break;
                        case 14: numToHexademical = "E" + numToHexademical;
                            break;
                        case 15: numToHexademical = "F" + numToHexademical;
                            break;
	                }
	            }
                else
                {
                   numToHexademical = hex + numToHexademical;
                }
                
                num /= 16;
                
            }
            return numToHexademical;
        }
    }
}
