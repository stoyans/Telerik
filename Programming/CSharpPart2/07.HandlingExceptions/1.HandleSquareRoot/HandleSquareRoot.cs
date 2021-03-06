/*Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.*/

using System;
using System.Collections.Generic;

class HandleSquareRoot
{
	static int ReadNumber()
	{
		int number = int.Parse(Console.ReadLine());
		return number;
	}
	
	static double SquareRoot(double num)
	{
		double result = Math.Sqrt(num);
		
		if (double.IsNaN(result)) 
		{
			throw new ArgumentException();
		}
		return result;
	}
	
	static void Main()
	{
		try 
		{
			double read = ReadNumber();
			Console.WriteLine (SquareRoot(read));
		} 
		catch (ArgumentException)
		{
			Console.WriteLine ("Invalid Number!");
		}
		catch (FormatException)
		{
			Console.WriteLine ("Invalid Number!");
		}
		finally
		{
			Console.WriteLine ("Good Bye!");
		}
		
	}
}