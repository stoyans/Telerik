/*Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

﻿using System;
using System.Collections.Generic;

class FindANumberInArray
{
    static void Main()
    {
        Console.Write("the size of the matrix: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("the value we're looking for, K: ");
        int K = int.Parse(Console.ReadLine());
        Random num = new Random();
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = num.Next(0, 20);
            //array [i] = int.Parse (Console.ReadLine ());
        }

        Array.Sort(array);
        Console.WriteLine(string.Join(" ", array));

        int returnValue = Array.BinarySearch(array, K);      // save the return value of Array.BinarySearch method
        int position = ~(returnValue); // if the value is not found the ~(returnValue) returns the index(position) of the first element which is bigger than the value we're looking for.

        if (returnValue < 0)
        {
            if (position - 1 < 0)
            {
                if (array[position] > K)
                {
                    Console.WriteLine("There's no number in array <= K");
                }
                else
                {
                    Console.WriteLine("The largest number in the array which is <= K : {0}", array[position]);
                }

            }
            else
            {
                Console.WriteLine("The largest number in the array which is <= K : {0}", array[position - 1]);
            }
        }
        else
        {
            Console.WriteLine("The largest number in the array which is <= K : {0}", K);
        }

    }
}