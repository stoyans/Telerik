/*Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Collections.Generic;

class _Add2Numbers
{
    static void Main()
    {
        Console.WriteLine("value of the first positive number: ");
        string firstNum = Console.ReadLine();
        Console.WriteLine("value of the second positive number: ");
        string secondNum = Console.ReadLine();

        //adding zeros on left to make the lenghts of the numbers equal
        if (firstNum.Length > secondNum.Length)
        {
            secondNum = secondNum.PadLeft(firstNum.Length, '0');
        }
        else
        {
            firstNum = firstNum.PadLeft(secondNum.Length, '0');
        }
			
		Console.WriteLine ();
        Console.Write("The sum of the numbers is: ");
		Console.WriteLine(string.Join("", Add2Numbers(firstNum, secondNum)));
		
	}

    static byte[] Add2Numbers(string firstArray, string secondArray)
    {
        int carry = 0;
        List<byte> numberFinal = new List<byte>();

        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            if ((firstArray[i] - 48) + (secondArray[i] - 48) + carry > 9)
            {
                numberFinal.Add((byte)((firstArray[i] - 48 + secondArray[i] - 48 + carry) % 10));
                carry = (byte)(firstArray[i] - 48 + secondArray[i] - 48 + carry) / 10;
            }
            else
            {
                numberFinal.Add((byte)(firstArray[i] - 48 + secondArray[i] - 48 + carry));
                carry = 0;
            }
        }

        if (carry != 0)
        {
            numberFinal.Add((byte)carry);
        }

        numberFinal.Reverse();
        return numberFinal.ToArray();
    }
}