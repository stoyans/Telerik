using System;
using System.Collections.Generic;
using System.Text;

class GreedyDwarf
{
    static void Main()
    {
        string valley = Console.ReadLine();
        int M = int.Parse(Console.ReadLine());
        string[] pattern = new string[M];

        string[] splitvalley = valley.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<string[]> patterns = new List<string[]>();

        for (int i = 0; i < M; i++)
        {
            pattern[i] = Console.ReadLine();
            string[] splitpattern = pattern[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            patterns.Add(splitpattern);

        }
        long sum = long.Parse(splitvalley[0]);
        long bestSum = long.MinValue;


        bool[] check = new bool[splitvalley.Length];

        for (int i = 0; i < patterns.Count; i++)
        {
            int nextIndex = 0;

            for (int j = 0; j < patterns[i].Length; j++)
            {
                check[nextIndex] = true;
                nextIndex += int.Parse(patterns[i][j]);

                if (nextIndex >= 0 && nextIndex < splitvalley.Length && check[nextIndex] == false)
                {
                    sum += int.Parse(splitvalley[nextIndex]);
                }
                else
                {
                    break;
                }
                if (j == patterns[i].Length - 1)
                {
                    j = -1;

                }
                


            }
            //Console.WriteLine(sum);
            if (sum > bestSum)
            {
                check = new bool[splitvalley.Length];
                
                bestSum = sum;
                sum = long.Parse(splitvalley[0]);
            }

        }
        //if (bestSum == long.MinValue)
        //{
        //    bestSum = sum;
        //}

        Console.WriteLine(bestSum);
    }
}
