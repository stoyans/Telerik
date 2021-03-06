/*Write a method that reverses the digits of given decimal number. Example: 256 -> 652*/

using System;

class _ReverseDigits
{
    static void Main()
    {
		Console.Write ("value of the number: ");
		decimal num = decimal.Parse(Console.ReadLine());

		Console.WriteLine (ReverseDigits(num));
	}
	
	static int ReverseDigits (decimal number)
	{
		string numToString = Convert.ToString(number);
		string result = null;
		
		for (int i = numToString.Length - 1; i >= 0; i--) 
		{
			result += numToString[i];
		}
		return Convert.ToInt32(result);
	}
}