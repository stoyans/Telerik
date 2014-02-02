using System;

namespace FallDownArrays
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[8];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 7; i++)
            {
                for (int line = nums.Length - 1; line >= 1; line--)
                {
                    for (int bitposition = 8; bitposition >= 0; bitposition++)
                    {
                        if ((nums[line] >> bitposition & 1) == 0 && (nums[line - 1] >> bitposition & 1) == 1)
                        {
                            nums[line] |= 1 << bitposition;
                            nums[line - 1] &= ~(1 << bitposition);
                        }
                    }
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
