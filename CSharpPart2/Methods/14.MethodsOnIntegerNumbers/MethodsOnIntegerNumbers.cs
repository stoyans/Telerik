/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
 * Use variable number of arguments.*/

using System;
using System.Collections.Generic;

class _MethodsOnIntegerNumbers
{
    static void Main()
    {
        Console.WriteLine("How many integers do you want to enter (must be > 0): ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("Minimum number is: {0}",minimum(array));
        Console.WriteLine("Maximum number is: {0}", maximum(array));
        Console.WriteLine("The sum of the numbers is: {0}",sum(array));
        Console.WriteLine("The average of all numbers is: {0:F3}",average(array));

    }

    static int minimum(int[] array)
    {
        int min = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }

    static int maximum(int[] array)
    {
        int max = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static int sum(int[] array)
    {
        int sumNums = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sumNums += array[i];
        }

        return sumNums;
    }

    static decimal average(int[] array)
    {
        int sumNums = sum(array);

        return (decimal)sumNums / array.Length;
    }

}