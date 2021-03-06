/*You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. 
 * Example: string = "43 68 9 23 318"  result = 461*/

using System;
using System.Collections.Generic;

class SumOfSequence
{

    static int Sum(string sequence)
    {
        int sum = 0;
        string[] nums = sequence.Split(' ');

        foreach (string number in nums)
        {
            sum += int.Parse(number);
        }

        return sum;
    }

    static int SumLongVersion(string sequence)
    {
        int sum = 0;
        string numTOString = string.Empty;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == ' ')
            {
                sum += int.Parse(numTOString);
                numTOString = string.Empty;
            }
            else
            {
                numTOString += (sequence[i] - 48);
            }
        }

        sum += int.Parse(numTOString);

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string like the example: (\"43 68 9 23 318\")");
        string sequence = Console.ReadLine();

        Console.WriteLine(Sum(sequence));

        Console.WriteLine(SumLongVersion(sequence));
    }
}