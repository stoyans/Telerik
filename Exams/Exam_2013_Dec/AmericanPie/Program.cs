using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        checked
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            decimal fraction1 = (decimal)A / B;
            decimal fraction2 = (decimal)C / D;
            BigInteger sum = 0;
            decimal sumfrac = 0;
            BigInteger denominator = (BigInteger)B * D;
            BigInteger nominator1 = (BigInteger)A * D;
            BigInteger nominator2 = (BigInteger)B * C;
            BigInteger sumnom = nominator1 + nominator2;

            //Console.WriteLine("{0:F20}",fraction1);
            //Console.WriteLine("{0:F20}", fraction2);

            if (fraction1 + fraction2 >= 1)
            {
                sum = (int)(fraction1 + fraction2);
                Console.WriteLine(sum);
                Console.WriteLine("{0}/{1}", sumnom, denominator);

            }
            else
            {
                sumfrac = fraction2 + fraction1;
                Console.WriteLine("{0:F20}", sumfrac);
                Console.WriteLine("{0}/{1}", sumnom, denominator);
            }
        }

    }
}

