/*Write a method that adds two polynomials.  * Represent them as arrays of their coefficients as in the example below: x2 + 5 = 1x2 + 0x + 5   Extend the program to support also subtraction and multiplication of polynomials.*/

using System;
using System.Collections.Generic;

class _Polynomials
{
    static void Main()
    {
        Console.WriteLine("enter the size of the first polynomial");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the size of the second polynomial");
        int size2 = int.Parse(Console.ReadLine());
        int[] firstNum = new int[Math.Max(size, size2)];
        int[] secondNum = new int[Math.Max(size, size2)];

        Console.WriteLine();

        Console.WriteLine("enter the coefficients of the first polynomial starting from index 0");
        for (int i = 0; i < size; i++)
        {
            Console.Write("x^{0}.", i);
            firstNum[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(firstNum);

        Console.WriteLine("enter the coefficients of the second polynomial starting from index 0");
        for (int i = 0; i < size2; i++)
        {
            Console.Write("x^{0}.", i);
            secondNum[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(secondNum);
        Console.WriteLine();

        Console.WriteLine("Choose the operation for the polynomials:\n1.Add\n2.Subtraction\n3.Multiplication");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Add2Numbers(firstNum, secondNum);
                break;
            case 2: subtract2Numbers(firstNum, secondNum);
                break;
            case 3: multiplication(firstNum, secondNum);
                break;
            default: Console.WriteLine("wrong choice!");
                break;
        }

    }

    static void Add2Numbers(int[] firstArray, int[] secondArray)
    {
        List<int> numberFinal = new List<int>();

        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            numberFinal.Add(firstArray[i] + secondArray[i]);

        }

        numberFinal.Reverse();
        printResult(numberFinal.ToArray());
    }

    static void subtract2Numbers(int[] firstArray, int[] secondArray)
    {
        List<int> numberFinal = new List<int>();

        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            numberFinal.Add(firstArray[i] - secondArray[i]);

        }

        numberFinal.Reverse();
        printResult(numberFinal.ToArray());
    }

    static void multiplication(int[] firstArray, int[] secondArray)
    {
        List<int> numberFinal = new List<int>();

        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            numberFinal.Add(firstArray[i] * secondArray[i]);

        }

        numberFinal.Reverse();
        printResult(numberFinal.ToArray());
    }

    static void printResult(int[] array)
    {
        Array.Reverse(array);

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i > 0)
            {
                Console.Write("{0}.x^{1} + ", array[i], i);
            }
            else
            {
                Console.Write("{0}.x^{1} ", array[i], i);
            }
            
        }
    }
}