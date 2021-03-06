/*Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.*/

using System;

public class NumberInArray
{
    static void Main()
    {
		Console.Write ("the size of the array: ");
		int size = int.Parse(Console.ReadLine());
		int[] array = new int[size];
        Console.WriteLine("enter the number which will be searched: ");
		int number = int.Parse(Console.ReadLine());
		
		Random num = new Random();
		
		for (int i = 0; i < size; i++) 
		{
			array[i] = num.Next(0,20);
		}
        Console.WriteLine(string.Join(" ", array));
		Console.WriteLine ("The number {0} is found {1} time(s)",number,findNum(array, number));
		
	}
	
	public static int findNum(int[] array, int number)
	{
		int count = 0;
		
		for (int i = 0; i < array.Length; i++) 
		{
			if (array[i] == number) 
			{
				count++;
			}
		}
		
		return count;
	}
}