using System;

namespace Task5_BiggerNumber
{
    class Task5_BiggerNumber
    {
        static void Main()
        {
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int bigger = num1 > num2 ? num1 : num2;

            Console.WriteLine("The bigger number is: {0}", bigger);

        }
    }
}
