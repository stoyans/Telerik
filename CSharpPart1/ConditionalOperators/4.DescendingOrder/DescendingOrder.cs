using System;

namespace _4.DescendingOrder
{
    class DescendingOrder
    {
        static void Main()
        {
            Console.Write("The first number is: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("The second number is: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("The third number is: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num1, num3, num2);
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num2, num3, num1);
                }
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                if (num1 >= num2)
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num3, num1, num2);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", num3, num2, num1);
                }
            }
        }
    }
}
