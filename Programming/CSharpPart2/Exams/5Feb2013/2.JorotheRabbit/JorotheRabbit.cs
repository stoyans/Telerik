using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.JorotheRabbit
{
    class JorotheRabbit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(new char[] { ',', ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numsToInt = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsToInt[i] = int.Parse(nums[i]);
            }

            int stepsCount = 1;
            int bestCount = int.MinValue;

            for (int i = 0; i < numsToInt.Length; i++)
            {
                for (int step = 1; step < numsToInt.Length; step++)
                {
                    int index = i;
                    int nextStep = (step + i) % numsToInt.Length;

                    while (numsToInt[nextStep] > numsToInt[index] && nextStep != i)
                    {
                        index = (step + index) % numsToInt.Length;
                        nextStep = (nextStep + step) % numsToInt.Length;
                        stepsCount++;
                    }

                    if (stepsCount > bestCount)
                    {
                        bestCount = stepsCount;
                        
                    }
                    stepsCount = 1;


                }
            }
            Console.WriteLine(bestCount);
            
        }
    }
}
