using System;

namespace _8.GCD
{
    class GCD
    {
        static void Main()
        {
            Console.Write("enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");
            int secondtNum = int.Parse(Console.ReadLine());
            int reminder = int.MaxValue;

            Console.Write("The GCD of {0} and {1} is ", firstNum, secondtNum);

            while (reminder > 0)
            {
                reminder = firstNum % secondtNum;
                firstNum = secondtNum;
                secondtNum = reminder;
                
            }

            Console.WriteLine("{0}",firstNum);
        }
    }
}
