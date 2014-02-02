/*Write a program that reads two dates in the format: 
 * day.month.year and calculates 
 * the number of days between them. Example:*/

using System;
using System.Text;

namespace _16.NumberOfDaysBetweenDates
{
    class NumberOfDaysBetweenDates
    {
        static void Main()
        {
           
            Console.Write("enter the day for the first date: ");
            byte day = byte.Parse(Console.ReadLine());
            Console.Write("enter the month for the first date: ");
            byte month = byte.Parse(Console.ReadLine());
            Console.Write("enter the year for the first date: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("enter the day for the second date: ");
            byte daySecond = byte.Parse(Console.ReadLine());
            Console.Write("enter the month for the second date: ");
            byte monthSecond = byte.Parse(Console.ReadLine());
            Console.Write("enter the year for the second date: ");
            int yearSecond = int.Parse(Console.ReadLine());      

            DateTime firtDate = new DateTime(year, month, day);
            DateTime secondDate = new DateTime(yearSecond, monthSecond, daySecond);

            int countDays = 0;
            for (DateTime i = firtDate; i <= secondDate; i = i.AddDays(1))
            {
                countDays++;
            }

            Console.WriteLine("The days between two dates are: {0}",countDays);

        }
    }
}
