/*Write a program that finds the most frequent number in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} - > 4 (5 times)*/

using System;

class MostFrequent
{
    static void Main()
    {
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int biggestSum = 0;
        int num = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }

        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    sum++;
                }
            }
            if (sum > biggestSum)
            {
                num = array[i];
                biggestSum = sum;
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0}->({1} times)", num, biggestSum);
    }
}

