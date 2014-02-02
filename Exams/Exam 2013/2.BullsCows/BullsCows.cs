using System;

namespace _2.BullsCows
{
    class BullsCows
    {
        static void Main()
        {
            ushort secretNumber = ushort.Parse(Console.ReadLine());
            sbyte b = sbyte.Parse(Console.ReadLine());
            sbyte c = sbyte.Parse(Console.ReadLine());
            bool nums = false;
            string num = secretNumber.ToString();
            int temp = 0;
            int i;
            for (i = 1000; i <= 9999; i++)
            {

                int countb = 0;
                int countc = 0;

                string n = i.ToString();
                if (n[0] - 48 == 0 || n[1] - 48 == 0 || n[2] - 48 == 0 || n[3] - 48 == 0)
                {
                    continue;
                }

                for (int k = 0; k < 4; k++)
                {

                    int digit = n[k] - 48;
                    for (int d = 0; d < 4; d++)
                    {
                        if (digit == num[d]-48)
                        {
                            if (num[k]-48 == n[k]-48)
                            {
                                countb++;
                                break;
                            }
                            else if (num[d] - 48 != n[d] - 48 && n[k]-48 != temp)
                            {
                                temp = n[k]-48;
                                countc++;
                                break;
                            }
                        }

                    }


                }
                if (countb == b && countc == c)
                {
                    nums = true;
                    Console.Write("{0} ", i);
                    //countb = 0;
                    //countc = 0;
                }

            }
            if (nums == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
