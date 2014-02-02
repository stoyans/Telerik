using System;

namespace _2.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumV = 0;
            int sumM = 0;

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);
                string numto = num.ToString();


                if (numto.Length % 2 == 0)
                {


                    for (int k = 0; k <= numto.Length / 2 - 1; k++)
                    {

                        sumM += numto[k] - 48;

                    }

                    for (int k = numto.Length / 2; k <= numto.Length - 1; k++)
                    {

                        sumV += numto[k] - 48;

                    }
                }

                else
                {

                    for (int k = 0; k <= numto.Length / 2; k++)
                    {

                        sumM += numto[k] - 48;

                    }
                    for (int k = numto.Length / 2; k <= numto.Length - 1; k++)
                    {

                        sumV += numto[k] - 48;
                    }
                }



            }

            if (sumM == sumV)
            {
                Console.WriteLine("No {0}", sumM + sumV);

            }
            else if (sumM > sumV)
            {
                Console.WriteLine("M {0}", sumM - sumV);
            }
            else if (sumM < sumV)
            {
                Console.WriteLine("V {0}", sumV - sumM);
            }
        }
    }
}
