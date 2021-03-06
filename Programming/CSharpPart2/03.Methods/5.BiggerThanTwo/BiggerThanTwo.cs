/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).*/

using System;

class _BiggerThanTwo
{
    static void Main()
    {
		Console.Write ("the size of the array: ");
		int size = int.Parse(Console.ReadLine());
		Console.Write ("position of the element: ");
		int position = int.Parse(Console.ReadLine());
		
        //If the size is 0, the array is empty
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
		
		BiggerThanTwo(array, position);
		
	}
	
	static void BiggerThanTwo (int[] array, int position)
	{
		if (array.Length == 1) 
		{
			Console.WriteLine ("In the array there's only one element - {0}", array[0]);	
		}
        //checks if the chosen position is between 2nd and prelast(included) 
		else if (position > 0 && position < array.Length - 1) 
		{
			if (array[position] > array[position - 1] && array[position] > array[position+1]) 
			{
				Console.WriteLine ("The element on position {0} is bigger than its neighbours", position);
			}
			else
			{
				Console.WriteLine ("The element on position {0} is smaller or equal to one of its neighbours", position);
			}
		}
		else if (position == 0) 
		{
			if (position == 0 && array[0] > array[1]) 
			{
				Console.WriteLine ("The element on position 0 has only one neighbour on the right and it's bigger");
			}
			else
			{
				Console.WriteLine ("The element on position 0 has only one neighbour on the right and it's smaller");
			}
			
		}
        else if (position == array.Length - 1)
        {
            if (position == array.Length - 1 && array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine("The element on position {0} has only one neighbour on the left and it's bigger", position);
            }
            else
            {
                Console.WriteLine("The element on position {0} has only one neighbour on the left and it's smaller", position);
            }
        }
        else if (position > array.Length - 1 || position < 0)
        {
            Console.WriteLine("The chosen index is outside of the array");
        }
	}
}