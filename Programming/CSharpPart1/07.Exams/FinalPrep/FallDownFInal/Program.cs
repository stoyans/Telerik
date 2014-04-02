using System;

namespace FallDownFInal
{
    class Program
    {
        static void Main()
        {
            //Input

            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());

            //Solution
            for (int i = 0; i < 8; i++)
            {

                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n7 >> bitposition & 1) == 0 && (n6 >> bitposition & 1) == 1)
                    {
                        n7 |= 1 << bitposition;
                        n6 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n6 >> bitposition & 1) == 0 && (n5 >> bitposition & 1) == 1)
                    {
                        n6 |= 1 << bitposition;
                        n5 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n5 >> bitposition & 1) == 0 && (n4 >> bitposition & 1) == 1)
                    {
                        n5 |= 1 << bitposition;
                        n4 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n4 >> bitposition & 1) == 0 && (n3 >> bitposition & 1) == 1)
                    {
                        n4 |= 1 << bitposition;
                        n3 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n3 >> bitposition & 1) == 0 && (n2 >> bitposition & 1) == 1)
                    {
                        n3 |= 1 << bitposition;
                        n2 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n2 >> bitposition & 1) == 0 && (n1 >> bitposition & 1) == 1)
                    {
                        n2 |= 1 << bitposition;
                        n1 &= ~(1 << bitposition);
                    }
                }
                for (int bitposition = 0; bitposition < 8; bitposition++)
                {
                    if ((n1 >> bitposition & 1) == 0 && (n0 >> bitposition & 1) == 1)
                    {
                        n1 |= 1 << bitposition;
                        n0 &= ~(1 << bitposition);
                    }
                }
            }


            //Output

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
