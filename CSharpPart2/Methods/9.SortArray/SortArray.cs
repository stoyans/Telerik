/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Collections.Generic;

class _SortArray
{
    static void Main()
    {
        Console.Write("enter size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Random num = new Random();
        bool ascending;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num.Next(0, 20);
            //array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("--- original array ---");
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();
        Console.WriteLine("--- descending order ---");
        Console.WriteLine(string.Join(" ", Sort(array, ascending = false)));
        Console.WriteLine("--- ascending order ---");
        Console.WriteLine(string.Join(" ", Sort(array, ascending = true)));

    }

    static int[] Sort(int[] array, bool ascending)
    {

        for (int i = 0; i < array.Length; i++)
        {
            int currentNum = array[i];
            //maxValue returns the min or max found element depending the value of bool ascending
            int maxValue = getMax(currentNum, array, i, ascending);

            array[i] = array[maxValue];
            array[maxValue] = currentNum;
        }

        return array;
    }

    static int getMax(int currMax, int[] array, int position, bool ascending)
    {
        int bestValuePosition = 0;

        for (int i = position + 1; i < array.Length; i++)
        {
            if (ascending == false)
            {
                if (array[i] > currMax)
                {
                    bestValuePosition = i;
                    currMax = array[i];
                }
            }
            else
            {
                if (array[i] < currMax)
                {
                    bestValuePosition = i;
                    currMax = array[i];
                }
            }

        }
        //if no bigger or smaller number is found we return the current position
        if (bestValuePosition == 0)
        {
            return position;
        }
        return bestValuePosition;
    }
}