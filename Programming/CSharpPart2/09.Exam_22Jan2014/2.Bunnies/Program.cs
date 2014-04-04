using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _2.BunnyFactory
{
    class BunnyFactory
    {

        static BigInteger CurrentSum(List<BigInteger> cages, int i, BigInteger nextcages)
        {
            BigInteger curSum = 0;

            for (int next = i + 1; next <= i + nextcages; next++)
            {
                curSum += (BigInteger)cages[next];
            }

            return curSum;
        }
        static BigInteger CurrentProduct(List<BigInteger> cages, int i, int nextcages)
        {
            BigInteger curProduct = 1;

            for (int next = i + 1; next <= i + nextcages; next++)
            {
                curProduct *= (BigInteger)cages[next];
            }

            return curProduct;
        }
        static void Main()
        {
            List<BigInteger> cages = new List<BigInteger>();
            StringBuilder cagesToNums = new StringBuilder();
            string cage = string.Empty;
            BigInteger currentSum;
            BigInteger currentProduct;
            int nextCages = 0;

            while (true)
            {
                cage = Console.ReadLine();
                if (cage != "END")
                {
                    cages.Add(BigInteger.Parse(cage));
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < cages.Count; i++)
            {
                nextCages = 0;
                for (int j = 0; j <= i; j++)
                {
                    nextCages += (int)cages[j];
                }
                if (nextCages > cages.Count)
                {
                    break;
                }
                currentSum = CurrentSum(cages, i, nextCages);
                currentProduct = CurrentProduct(cages, i, nextCages);

                cages.RemoveRange(0, i);
                cages.RemoveRange(0, nextCages + 1);

                cages.Insert(0, (BigInteger)currentProduct);
                cages.Insert(0, (BigInteger)currentSum);
                for (int k = 0; k < cages.Count; k++)
                {
                    cagesToNums.Append(cages[k]);
                }
                for (int n = 0; n < cagesToNums.Length; n++)
                {
                    if (cagesToNums[n] == '0' || cagesToNums[n] == '1')
                    {
                        cagesToNums.Remove(n, 1);
                        n--;
                    }
                }
                cages.Clear();

                for (int p = 0; p < cagesToNums.Length; p++)
                {
                    cages.Add(cagesToNums[p] - 48);
                }
                cagesToNums.Clear();


            }

            StringBuilder result = new StringBuilder();
            for (int index = 0; index < cages.Count; index++)
            {

                result.Append(cages[index]);
                if (index != cages.Count - 1)
                {
                    result.Append(' ');
                }
            }
            Console.WriteLine(result);

        }
    }
}
