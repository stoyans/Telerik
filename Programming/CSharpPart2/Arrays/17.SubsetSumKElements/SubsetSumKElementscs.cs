/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 *Find in the array a subset of K elements that have sum S or indicate about its absence.*/
//The algorithm is the same as previous task with one change of the condition: && nums.Count == K

using System;
using System.Collections.Generic;

class SubsetSumKElements
{
    static void Main(string[] args)
    {
       
        Console.Write("enter length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("enter sum to be checked: ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("enter K: ");
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[length]; 
        int count = 0; 
        long sum = 0;
        int power = Convert.ToInt32(Math.Pow(2, length)) - 1;
        List<int> nums = new List<int>();


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine()); 
        }

        for (int i1 = 1; i1 <= power; i1++)
        { 
            for (int i2 = 0; i2 < length; i2++)
            { 
                int mask = 1 << i2;
                int bit = mask & i1;
                int bit1 = bit >> i2; 
                if (bit1 == 1)
                {        
                    sum += array[i2];
                    nums.Add(array[i2]);
                }
            }
            if (sum == S && nums.Count == K)
            {
                Console.Write("{");
                Console.Write(string.Join(", ", nums));
                Console.WriteLine("}");
                count++;
            }
            else
            {
                Console.WriteLine("There are NO subsets equal to {0}", S);
            }
            sum = 0;
            nums.Clear();

        }
        Console.WriteLine();
        Console.WriteLine("There are(is) {0} subset(s) equal(s) to {1}", count, S);
    }
}

