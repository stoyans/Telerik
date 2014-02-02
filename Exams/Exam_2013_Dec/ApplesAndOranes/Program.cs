using System;
using System.Numerics;

namespace ApplesAndOranes
{
    class Program
    {
        static void Main()
        {
            checked
            {
                long num = long.Parse(Console.ReadLine());
                num = Math.Abs(num);

                string numToString = Convert.ToString(num);
                long sumEven = 0;
                long sumOdd = 0;
                //int a = numToString[0]-48;

                for (int position = 0; position < numToString.Length; position++)
                {

                    if ((numToString[position] - 48) % 2 == 0)
                    {
                        sumEven += (long)(numToString[position] - 48);
                    }
                    else
                    {
                        sumOdd += (long)(numToString[position] - 48);
                    }
                }

                if (sumEven > sumOdd)
                {
                    Console.WriteLine("apples {0}", sumEven);
                }
                else if (sumEven < sumOdd)
                {
                    Console.WriteLine("oranges {0}", sumOdd);
                }
                else
                {
                    Console.WriteLine("both {0}", sumOdd);
                }
            }
        }
    }
}
