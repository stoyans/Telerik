using System;

namespace Task_3_ComapreFloat
{
    class Task_3_CompareFloat
    {
        static void Main()
        {
            Console.WriteLine("For decimal separator use (,)");
            Console.Write("Enter first number: ");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Are the numbers equal? \n{0}", firstNumber == secondNumber);

        }
    }
}
