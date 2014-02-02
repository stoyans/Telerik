/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.*/

using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("enter K: ");
        int K = int.Parse(Console.ReadLine());
        int maxCount = 0;

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array); //Sorting the array and with the loop below we sum the first biggest K elements

        Console.Write("{");
        for (int i = array.Length - 1; i >= array.Length - K; i--)
        {
            maxCount += array[i];
            Console.Write("{0, 2}",array[i]);
        }
        

        Console.WriteLine("}");
        Console.WriteLine("Maximal sum is: {0}",maxCount);
    }
}

