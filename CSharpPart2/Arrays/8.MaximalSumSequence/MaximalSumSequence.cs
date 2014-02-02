/*Write a program that finds the sequence of maximal sum in given array. Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} {2, -1, 6, 4}*/

using System;
using System.Collections.Generic;

class MaximalSumSequence
{
    static void Main()
    {
        //Random num = new Random();
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        int biggestSum = int.MinValue;
        int start = 0;
        int end = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        MaxSumSequence(array);

        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;

            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];

                if (currentSum > biggestSum)
                {
                    start = i;
                    biggestSum = currentSum;
                    end = j;
                }
            }

        }
        Console.WriteLine("Result from long algorithm");
        Console.Write("{");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("The sum is: {0}",biggestSum);
    }

    //Kadane algorithm
    static void MaxSumSequence(int[] array)
    {
        int currentSum = array[0];
        int bestSum = array[0];
        int start = 0;
        int tempStart = 0;
        int end = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                tempStart = i;
            }
            else
            {
                currentSum += array[i];
            }
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                start = tempStart;
                end = i;                     
            }

        }
        Console.WriteLine("Result from Kadane's Algorithm");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

    }
}

