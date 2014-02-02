using System;

namespace Task1_FindSum
{
    class Task1_FindSum
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
