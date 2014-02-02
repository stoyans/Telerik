/* Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm */

using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        Random num = new Random();
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("enter the number we're searching for: ");
        int element = int.Parse(Console.ReadLine()); // the element to be searched
        int start = 0; //identifies the first index of the array
        bool inArray = false; // checks if the element is found in the array

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine()); //filllin the array
        }
        Array.Sort(array); //sorting the array
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", array));

        bool startIn = false; //We use this boolean to break the loop if the algorithm has reached the most left element and the searched num is not in the array
        while (N - start >= 1)
        {
            if (array[(N + start) / 2] == element)
            {
                Console.WriteLine("The index of {0} is {1}", element, Array.IndexOf(array, array[(N + start) / 2]));
                inArray = true;
                break;
            }
            if (startIn == true)
            {
                break;
            }
            else if (array[(N + start) / 2] > element)
            {
                N = (N + start) / 2;
            }
            else if (array[(N + start) / 2] < element)
            {
                if (start == 0)
                {
                    startIn = true;
                }
                start = N / 2;
            }
        }
        Console.WriteLine();
        if (!inArray)
        {
            Console.WriteLine("The number is not available in the array");
        }
        
    }
}
