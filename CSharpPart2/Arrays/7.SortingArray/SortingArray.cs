/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Collections.Generic;

class SortingArray
{
    static void Main()
    {
        Random num = new Random();
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        
        int temp = 0;
        int position = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num.Next(0, 100); //the area of the generated numbers can be changed
        }

        Console.WriteLine(string.Join(", ", array));

        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i]; //save the value of the first element
            int smallest = int.MaxValue;

            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < smallest)
                {
                    position = j; //save the position of the smallest element
                    smallest = array[j]; //save the smallest element
                }
            }
            array[position] = temp; //replace values of the smallest and the current element
            array[i] = smallest;
        }

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", array));
    }
}