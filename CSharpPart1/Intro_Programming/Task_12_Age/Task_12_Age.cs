using System;

namespace Task_12_Age
{
    class Task_12_Age
    {
        static void Main()
        {
            byte age;
            
            while (true)
            {
                Console.Write("Type your age (between 0-255): ");
                string input = Console.ReadLine();

                if (!byte.TryParse(input, out age))
                {
                    Console.WriteLine("Wrong input! Try again..."); 
                }
                else
                {
                    Console.WriteLine("Your age after 10 years will be {0} years.", (age + 10));
                    break;
                }
            }

        }
    }
}
