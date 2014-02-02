using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine()); 

            int[] array = { n0, n1, n2, n3, n4, n5, n6, n7 };

            n0 = n1 = n2 = n3 = n4 = n5 = n6 = n7 = 0;

            for (int k = 0; k < 8; k++)
            {
                for (int k1 = 0; k1 < 8; k1++)
                {
                    for (int k2 = 7; k2 >= 0; k2--)
                    {
                        int bit = array[k] & (1 << k1);
                        if (bit == 0)
                        {
                            break;
                        }
                        else if (bit != 0)
                        {
                            if ((n7 & (1 << k1)) == 0 && k2 == 7)
                            {
                                n7 |= n7 | bit;
                                break;
                            }
                            if ((n6 & (1 << k1)) == 0 && k2 == 6)
                            {
                                n6 |= n6 | bit;
                                break;
                            }
                            if ((n5 & (1 << k1)) == 0 && k2 == 5)
                            {
                                n5 |= n5 | bit;
                                break;
                            }
                            if ((n4 & (1 << k1)) == 0 && k2 == 4)
                            {
                                n4 |= n4 | bit;
                                break;
                            }
                            if ((n3 & (1 << k1)) == 0 && k2 == 3)
                            {
                                n3 |= n3 | bit;
                                break;
                            }
                            if ((n2 & (1 << k1)) == 0 && k2 == 2)
                            {
                                n2 |= n2 | bit;
                                break;
                            }
                            if ((n1 & (1 << k1)) == 0 && k2 == 1)
                            {
                                n1 |= n1 | bit;
                                break;
                            }
                            if ((n0 & (1 << k1)) == 0 && k2 == 0)
                            {
                                n0 |= n0 | bit;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
        }
    }
}
