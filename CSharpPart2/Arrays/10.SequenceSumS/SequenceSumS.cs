/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;

class SequenceSumS
{
    static void Main()
    {
        Console.Write("enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("enter sum to be checked: ");
        int S = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        bool isSum = false;
        int start = 0; //marks the start of the sequence equals to S;
        int end = 0; // marks the end of the sequence equals to S;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine()); // filling the array
        }

        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0; // reset the current sum if it's different from S

            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];

                if (currentSum == S)
                {
                    isSum = true;
                    start = i;
                    end = j;
                }
            }

        }

        if (!isSum)
        {
            Console.WriteLine("There is NO sequence equals to {0}", S);
        }
        else
        {
            Console.WriteLine();
            Console.Write("{");
            for (int i = start; i <= end; i++) //Printing the result
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("}");
        }
        
    }
}

