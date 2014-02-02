using System;

namespace Task4_DividedBy5
{
    class Task4_DividedBy5
    {
        static void Main()
        {
            Console.Write("First number is: ");
            uint num1 = uint.Parse(Console.ReadLine());
            Console.Write("Second number is: ");
            uint num2 = uint.Parse(Console.ReadLine());
            uint p = 0;
            //Броячът p ще увеличава стойността си с 1, когато число в зададения интервал се дели без остатък на 5
            for (uint i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }

            Console.WriteLine("The numbers between {0} and {1} are(is) {2}", num1, num2, p);
        }
    }
}
