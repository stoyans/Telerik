/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class _GetMax
{
    static void Main()
    {
		Console.Write ("first number: ");
		int firstNum = int.Parse(Console.ReadLine());
		Console.Write ("second number: ");
		int secondNum = int.Parse(Console.ReadLine());
		
		Console.WriteLine ("Bigger number is {0}",GetMax(firstNum, secondNum));
	}
	
	static int GetMax(int num1, int num2)
	{
		return Math.Max(num1, num2);
	}
	
}