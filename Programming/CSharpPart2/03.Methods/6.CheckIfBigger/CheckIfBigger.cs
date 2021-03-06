/*Write a method that returns the index of the first element in array that is bigger than its neighbors, 
 * or -1, if there’s no such element.*/

using System;

class _CheckIfBigger
{
    static void Main()
    {
		Console.Write ("the size of the array: ");
		int size = int.Parse(Console.ReadLine());
		
		if (size == 0) 
		{
			Console.WriteLine ("No elements in the array");	
			return;
		}
		int[] array = new int[size];		
		Random num = new Random();
		
		for (int i = 0; i < size; i++) 
		{
			array[i] = num.Next(0,20);
		}
		
		Console.WriteLine(string.Join(" ", array));

        if (CheckIfBigger(array) == -1)
        {
            Console.WriteLine("In the array there is NO element bigger than its neighbours");
        }
        else
        {
            Console.WriteLine("The first element which is bigger than its neighbours has index: {0}", CheckIfBigger(array));
        }
		
		
	}
	
	static int CheckIfBigger (int[] array)
	{
		
		for (int i = 1; i < array.Length - 1; i++) 
		{
			if (array[i] > array[i-1] && array[i] > array[i+1]) 
			{
				return Array.IndexOf(array, array[i]);
			}
		}
		
		return -1;
	}
}