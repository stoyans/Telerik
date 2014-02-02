/*Write a program that finds the maximal sequence of equal elements in an array.*/

using System;
using System.Collections.Generic;

class MaxSequence
{
    static void Main()
    {
        Console.Write("enter the size of the array: ");
        int length = int.Parse(Console.ReadLine());
        int currentNum = 0;
        int count = 1;
        int maxCount = int.MinValue;

        List<int> sequence = new List<int>();
        int[] sequenceMax = new int[0];
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        currentNum = array[0];
        sequence.Add(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            if (currentNum == array[i])
            {
                count++;
                sequence.Add(array[i]);

                if (i == array.Length - 1)
                {
                    if (sequence.Count >= sequenceMax.Length)
                    {
                        sequenceMax = new int[sequence.Count];
                        sequence.CopyTo(sequenceMax);
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }
            else
            {
                currentNum = array[i];
                if (count >= maxCount)
                {
                    maxCount = count;
                }
                count = 1;

                if (sequence.Count >= sequenceMax.Length)
                {
                    sequenceMax = new int[sequence.Count];
                    sequence.CopyTo(sequenceMax);
                }
                sequence.Clear();
                sequence.Add(array[i]);
            }
        }

        if (array.Length == 1)
        {
            Console.WriteLine("Maximal sequence of equal elements is 1 -- {0}", array[0]);
        }
        else
        {
            Console.WriteLine("Maximal sequence of equal elements is: {0}", maxCount);
            Console.Write("{");
            Console.Write(string.Join(", ", sequenceMax));
            Console.WriteLine("}");
        }
        
    }
}

