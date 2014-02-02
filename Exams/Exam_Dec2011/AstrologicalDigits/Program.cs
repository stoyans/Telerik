using System;

namespace AstrologicalDigits
{
    class Program
    {
        static void Main()
        {

            string N = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i]-48 >= 1 && N[i]-48 <= 9)
                {
                    sum += N[i] - 48;
                }
                if (i == N.Length - 1 && sum > 9)
                {
                    N = sum.ToString();
                    i = -1;
                    sum = 0;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
