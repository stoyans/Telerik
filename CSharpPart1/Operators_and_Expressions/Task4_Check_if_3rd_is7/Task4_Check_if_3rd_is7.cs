using System;

namespace Task4_Check_if_3rd_is7
{
    class Task4_Check_if_3rd_is7
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int num = int.Parse(Console.ReadLine());
            //Делим на 100, за да намерим цялата част от 3тата цифра наляво
            //След това проверяваме дали остатъкът от %10 е равен на 7
            num /= 100;
            int reminder = num % 10;

            Console.WriteLine(reminder == 7 ? "Third digit from right to left is 7" : "Third digit from right to left is NOT 7");

        }
    }
}
