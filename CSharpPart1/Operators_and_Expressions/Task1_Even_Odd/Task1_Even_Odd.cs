using System;

namespace Task1_Even_Odd
{
    class Task1_Even_Odd
    {
        static void Main()
        {
            Console.Write("Enter a numbers: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? "The number is even" : "The number is odd");
        }
    }
}
