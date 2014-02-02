using System;

namespace Task2_Divided_by_5n7
{
    class Task2_Divided_by_5n7
    {
        static void Main()
        {
            Console.Write ("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("The number {0} can be divided by 5 and 7 without reminder", num);
            }
            else
            {
                Console.WriteLine("The number {0} CAN NOT be divided by 5 and 7 without reminder", num);
            }

        }
    }
}
