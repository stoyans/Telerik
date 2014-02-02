using System;

namespace DancingBits
{
    class Program
    {
        static void Main()
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            uint[] nums = new uint[N];
            int countOne = 0;
            int countZero = 0;
            int resultOne = 0;
            int resultZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = uint.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                uint numZero = nums[i];
                uint numOne = numZero;

                while (numOne > 0)
                {
                    uint bit = numOne & 1;
                    if (bit == 1)
                    {
                        countOne++;
                    }
                    if (bit == 0)
                    {
                        if (countOne == K)
                        {
                            resultOne++;
                            countOne = 0;
                        }
                        else
                        {
                            countOne = 0;
                        }
                        
                    }
                    if (numOne == 1 && i == 0)
                    {
                        if (countOne == K)
                        {
                            resultOne++;
                        }
                    }
                    numOne = numOne >> 1;

                }

                while (numZero != 0)
                {
                    uint bit = numZero & 1;
                    if (bit == 0)
                    {
                        countZero++;
                    }
                    if (bit == 1)
                    {
                        if (countZero == K)
                        {
                            resultZero++;
                            countZero = 0;
                        }
                        else
                        {
                            countZero = 0;
                        }

                    }
                    numZero = numZero >> 1;

                }
            }
            Console.WriteLine(resultOne+resultZero);

        }
    }
}
