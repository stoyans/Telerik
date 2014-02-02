using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Patterns
{
    class Patterns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int row = 0;
            string input = string.Empty;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] nums = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < nums.Length; col++)
                {
                   matrix[row, col] = int.Parse(nums[col]);
                }
                row++;
            }

            //Console.WriteLine();
            BigInteger sum1 = 0;
            BigInteger bestSum = long.MinValue;
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (rows == cols)
	                {
                        sum1 += matrix[rows, cols];
                	}
                    
                }
            }

           // Console.WriteLine("NO {0}", sum);
            BigInteger sum = 0;
            bool inside = false;
            for (int rows = 0; rows < n - 2; rows++)
            {   

                for (int cols = 0; cols < n - 4; cols++)
                {
                    if (matrix[rows, cols] < matrix[rows, cols + 1] && matrix[rows, cols + 1] < matrix[rows, cols + 2]
                        && matrix[rows, cols + 2] < matrix[rows + 1, cols + 2] && matrix[rows + 1, cols + 2] < matrix[rows + 2, cols + 2]
                        && matrix[rows + 2, cols + 2] < matrix[rows + 2, cols + 3] && matrix[rows + 2, cols + 3] < matrix[rows + 2, cols + 4])
                    {
                        sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2]
                            + matrix[rows + 1, cols + 2] + matrix[rows + 2, cols + 2] + matrix[rows + 2, cols + 3]
                            + matrix[rows + 2, cols + 4];
                        inside = true;
                    }
 
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }

            }

            if (inside == true)
            {
                Console.WriteLine("YES {0}", bestSum);
            }
            else
            {
                Console.WriteLine("NO {0}", sum1);
            }
            
        }
    }
}
