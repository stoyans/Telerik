using System;

namespace _1.ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            Console.Write("The first number is: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("The second number is: ");
            int num2 = int.Parse(Console.ReadLine());
            int temp = num1;
            //В temp ще запазим стойснотта на едната променлива, за да може при изпълнено условие да зададем на num2 стойността на num1
            if (num1 > num2)
            {
                num1 = num2;
                num2 = temp;

                Console.WriteLine("num1 is greater than num2 - exchanged values are: {0} and {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("num2 is greater than num1 - values remain the same: {0} and {1}", num1, num2);
            }
                        
        }
    }
}
