/*Write a method that returns the last digit of given integer as an English word.
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".*/

using System;

class LastDigitInWords
{
    static void Main()
    {
		Console.Write ("num = ");
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine (InWords(num));
	}
	
	static string InWords(int number)
	{
		int lastDigit = number%10;
		
		if (lastDigit == 0) 
		{
			return "Zero";
		}
		if (lastDigit == 1) 
		{
			return "One";
		}
		if (lastDigit == 2) 
		{
			return "Two";
		}
		if (lastDigit == 3) 
		{
			return "Three";
		}
		if (lastDigit == 4) 
		{
			return "Four";
		}
		if (lastDigit == 5) 
		{
			return "Five";
		}
		if (lastDigit == 6) 
		{
			return "Six";
		}
		if (lastDigit == 7) 
		{
			return "Seven";
		}
		if (lastDigit == 8) 
		{
			return "Eight";
		}
		if (lastDigit == 9) 
		{
			return "Nine";
		}
		
		return "0";
	}
}