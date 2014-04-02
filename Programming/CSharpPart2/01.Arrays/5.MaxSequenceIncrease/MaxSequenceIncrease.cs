/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;
using System.Collections.Generic;

class MaxSequenceIncrease
{
    static void Main()
    {
        Console.Write("enter the size of the array: ");
        int length = int.Parse(Console.ReadLine());

        List<int> sequence = new List<int>();
        int[] sequenceMax = new int[0];
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        sequence.Add(array[0]);

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                sequence.Add(array[i + 1]);
            }
            else
            {
                if (sequence.Count > sequenceMax.Length)
                {
                    sequenceMax = new int[sequence.Count];
                    sequence.CopyTo(sequenceMax);
                }
                sequence.Clear();
                sequence.Add(array[i+1]);
            }
        }
        if (sequence.Count >= sequenceMax.Length)
        {
            sequenceMax = new int[sequence.Count];
            sequence.CopyTo(sequenceMax);
        }
        Console.WriteLine();

        Console.Write("{");
        Console.Write(string.Join(", ", sequenceMax));
        Console.WriteLine("}");

    }
}

