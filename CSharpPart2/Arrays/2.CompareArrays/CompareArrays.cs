/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the size of the first array: ");
        int lengthOne = int.Parse(Console.ReadLine());
        Console.Write("enter the size of the second array: ");
        int lengthTwo = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[lengthOne];
        int[] arrayTwo = new int[lengthTwo];
        bool equal = true;

        if (lengthOne != lengthTwo)
        {
            equal = false;
        }
        else
        {
            /*Filling the arrays*/
            Console.WriteLine("Enter the elements of the first array");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            /*Compare*/
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                    break;
                }
            }
        }

        if (equal == true)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are NOT equal");
        }

    }
}

