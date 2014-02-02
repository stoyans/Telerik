/*Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Collections.Generic;

namespace _4.HexademicalToDecimal
{
    class HexademicalToDecimal
    {
        static void Main()
        {
            Console.Write("Hexademical number: ");
            string hexNum = Console.ReadLine();

            Console.WriteLine(HexademicalToDecimalConvert(hexNum));
        }

        static int HexademicalToDecimalConvert(string hexNum)
        {
            int numToDecimal = 0;

            for (int i = 0; i < hexNum.Length; i++)
            {
                int power = Convert.ToInt32(Math.Pow(16, hexNum.Length - 1 - i));
                int hex;

                if (hexNum[i] >= 'A' && hexNum[i] <= 'F')
	            {
                    switch ((char)hexNum[i])
	                {
                        case 'A': hex = 10;
                            numToDecimal += power*hex;
                            break;
                        case 'B': hex = 11;
                            numToDecimal += power*hex;
                            break;
                        case 'C': hex = 12;
                            numToDecimal += power*hex;
                            break;
                        case 'D': hex = 13;
                            numToDecimal += power*hex;
                            break;
                        case 'E': hex = 14;
                            numToDecimal += power*hex;
                            break;
                        case 'F': hex = 15;
                            numToDecimal += power*hex;
                            break;
	                }    		            
	            }
                else
                {
                    hex = hexNum[i]-48;
                    numToDecimal += power*hex;
                }                
            }

            return numToDecimal;
        }    
    }
}
