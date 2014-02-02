using System;

namespace _2.Sign
{
    class Sign
    {
        static void Main()
        {
            Console.Write("The first number is: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("The second number is: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("The third number is: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                if (num2 >= 0)
                {
                    if (num3 >= 0)
                    {
                        Console.WriteLine("Product sign is \"+\" ");
                    }
                    else
                    {
                        Console.WriteLine("Product sign is \"-\" ");
                    }
                }
                else
                {
                    if (num3 >= 0)
                    {
                        Console.WriteLine("Product sign is \"-\" ");
                    }
                    else
                    {
                        Console.WriteLine("Product sign is \"+\" ");
                    }
                }

            }
            else
            {
                if (num2 >= 0)
                {
                    if (num3 >= 0)
                    {
                        Console.WriteLine("Product sign is \"-\" ");
                    }
                    else
                    {
                        Console.WriteLine("Product sign is \"+\" ");
                    }
                }
                else
                {
                    if (num3 >= 0)
                    {
                        Console.WriteLine("Product sign is \"+\" ");
                    }
                    else
                    {
                        Console.WriteLine("Product sign is \"-\" ");
                    }
                }
            }
            
        }
    }
}
