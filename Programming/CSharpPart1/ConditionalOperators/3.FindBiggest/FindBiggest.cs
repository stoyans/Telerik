using System;

namespace _3.FindBiggest
{
    class FindBiggest
    {
        static void Main()
        {
            Console.Write("The first number is: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("The second number is: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("The third number is: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The biggest number is: {0}", num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {

                Console.WriteLine("The biggest number is: {0}", num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("The biggest number is: {0}", num3);
            }

        }
    }
}
