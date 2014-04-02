/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/

﻿using System;
using System.Collections.Generic;

class SortStrings
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] array = new string[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = Console.ReadLine();
        }
        Sort(array);
        Console.WriteLine(string.Join(" ", array));

    }

    static string[] Sort(string[] array)
    {
        string temp = null;
        string shortest = null;
        int position = 0;

        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i]; //save the value of the first element
            int smallest = int.MaxValue;

            for (int j = i; j < array.Length; j++)
            {
                if (array[j].Length < smallest)
                {
                    position = j; //save the position of the shortest element
                    shortest = array[j]; //save the shortest element
                    smallest = array[j].Length; //saves the length of the shortest string
                }
            }
            array[position] = temp; //replace values of the smallest and the current element
            array[i] = shortest;
        }
        return array;

    }
}