/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

using System;
using System.Collections.Generic;

class _GenerateRandomNumbers
{
    static void GenerateRandomNumbers()
    {
        Random num = new Random();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} -> {1}", i, num.Next(100, 201));
        }
    }

    static void Main()
    {
        GenerateRandomNumbers();
    }
}