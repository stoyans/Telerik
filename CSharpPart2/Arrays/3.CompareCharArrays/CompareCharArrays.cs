/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class Program
{
    static void Main()
    {

        Console.Write("enter the size of the first array: ");
        int lengthOne = int.Parse(Console.ReadLine());
        Console.Write("enter the size of the second array: ");
        int lengthTwo = int.Parse(Console.ReadLine());

        char[] arrayOne = new char[lengthOne];
        char[] arrayTwo = new char[lengthTwo];
        bool equal = true;

        if (lengthOne != lengthTwo)
        {
            Console.WriteLine("Arrays are NOT equal");
            return;
        }
        else
        {
            /*Filling the arrays*/
            Console.WriteLine("Enter the elements of the first array");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = char.Parse(Console.ReadLine());
            }

            /*Compare*/
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                    Console.WriteLine("Arrays are NOT equal");
                }
                if ((int)arrayOne[i] < (int)arrayTwo[i])
                {
                    Console.WriteLine("Array One is first in the lexicographical order");
                }
                if ((int)arrayOne[i] > (int)arrayTwo[i])
                {
                    Console.WriteLine("Array Two is first in the lexicographical order");
                }

            }
        }

        if (equal == true)
        {
            Console.WriteLine("Arrays are equal");
        }

    }
}

