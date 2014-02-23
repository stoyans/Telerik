using System;

namespace Task7_CheckIfPrime
{
    class Task7_CheckIfPrime
    {
        static void Main()
        {
            Console.Write("Number= ");
            int num = int.Parse(Console.ReadLine());
            bool IsPrime = false; // Декларираме булева променлива, която ще променя стойността си на TRUE,
                                  // ако някое от числата в интервал (2, корен от num) е делител на num (без остатък)
            // Може условието в цикъла да е i<=num, но от теорията за простите числа може да ограничим това условие до корен от num, като така ще ускорим и самия процес

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    IsPrime = true;
                    break;
                }
            }

            Console.WriteLine(IsPrime == true || num == 2? "The number is NOT prime.": "The number IS prime.");
        }
    }
}
