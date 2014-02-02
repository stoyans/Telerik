/*Write a program that can solve these tasks:Reverses the digits of a numberCalculates the average of a sequence of integersSolves a linear equation a * x + b = 0*/

using System;
using System.Collections.Generic;

class _MultiTaskingProgram
{
    static void Main()
    {
        Console.WriteLine(
            "Choose the operation you want to proceed to:" +
            "\n1.Reverse numbers' digits" +
            "\n2.Calculate the average of integers" +
            "\n3.Solves a linear equation"
            );

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int num = 0;
                do
                {
                    Console.Write("value of the number > 0: ");
                    num = int.Parse(Console.ReadLine());
                }
                while (num < 0);

                ReverseDigits(num);
                Console.WriteLine(ReverseDigits(num));
                break;

            case 2:
                int size = 0;
                do
                {
                    Console.WriteLine("How many integers do you want to enter (must be > 0): ");
                    size = int.Parse(Console.ReadLine());
                }
                while (size < 1);

                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The average of the sequence is: {0:F3}", average(array));
                break;

            case 3:
                Console.WriteLine("Solves a linear equation a * x + b = 0");
                int a = -1;
                do
                {
                    Console.Write("coefficient a (a != 0): ");
                    a = int.Parse(Console.ReadLine());
                }
                while (a == 0);

                Console.Write("coefficient b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("x= {0:F3}", linearEquation(a, b));
                break;

            default: Console.WriteLine("wrong choice!");
                break;
        }


    }

    static int ReverseDigits(int number)
    {
        string numToString = Convert.ToString(number);
        string result = null;

        for (int i = numToString.Length - 1; i >= 0; i--)
        {
            result += numToString[i];
        }
        return Convert.ToInt32(result);
    }

    static decimal average(int[] array)
    {
        decimal calculateAverage = 0;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        calculateAverage = (decimal)sum / array.Length;
        return calculateAverage;
    }

    static decimal linearEquation(int a, int b)
    {
        return (decimal)(-1 * b) / a;
    }

}