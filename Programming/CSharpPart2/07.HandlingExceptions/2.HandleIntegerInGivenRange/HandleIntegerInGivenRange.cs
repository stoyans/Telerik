/*Write a method ReadNumber(int start, int end) that enters an integer number in  * given range [start…end]. If an invalid number or non-number text is entered,  * the method should throw an exception.  * Using this method write a program that enters 10 numbers:a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

using System;
using System.Collections.Generic;

class HandleIntegerInGivenRange
{
	static void Input ()
	{
		Console.Write("choose left range: ");
		int leftRange = int.Parse(Console.ReadLine());
		Console.Write("choose right range: ");
		int rightRange = int.Parse(Console.ReadLine());
		
		ReadNumber(leftRange, rightRange);
	}
	
	static void ReadNumber(int start, int end)
	{
		for (int i = 0; i < 10; i++) 
		{
			int num = int.Parse(Console.ReadLine());
			
			if (num < start || num > end) 
			{
				throw new ArgumentOutOfRangeException ();
			}
			else
			{
				Console.WriteLine (num);
			}
		}
	}
	
	static void HandleExceptions()
	{
		try
		{
			Input();
		}
		catch (ArgumentOutOfRangeException) 
		{
			Console.WriteLine("The entered number is out of the chosen range!");
		}
		catch (FormatException)
		{
			Console.WriteLine ("Invalid number!");
		}
	}
	
	static void Main()
	{
		HandleExceptions();		
	}
}