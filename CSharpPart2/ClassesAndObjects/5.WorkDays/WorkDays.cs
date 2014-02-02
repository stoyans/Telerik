/*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;

namespace _5.WorkDays
{
    class WorkDays
    {

        static int CountWorkDays(DateTime nextDate)
        {

            string[] holiDays = 
            {
                "0l.01", "03.03", "01.05",
                "06.05", "22.09", "24.12",
                "25.12", "26.12"
            };

            int countWorkDays = 0;

            for (DateTime i = DateTime.Today; i <= nextDate; i = i.AddDays(1))
            {
                if (Convert.ToString(i.DayOfWeek) == "Saturday" || Convert.ToString(i.DayOfWeek) == "Sunday")
                {
                    continue;
                }
                else
                {
                    countWorkDays++;

                    for (int dates = 0; dates < holiDays.Length; dates++)
                    {
                        if (holiDays[dates] == i.ToString("dd.MM"))
                        {
                            //if the current date is holiday countWorkDays is subtract by 1
                            countWorkDays--;
                        }
                    }
                    
                }
            }

            return countWorkDays;
        }

        static void Main()
        {
            Console.Write("enter a day of the month: ");
            byte day = byte.Parse(Console.ReadLine());
            Console.Write("enter a month: ");
            byte month = byte.Parse(Console.ReadLine());
            Console.Write("enter a year (year > 2013): ");
            ushort year = ushort.Parse(Console.ReadLine());

            DateTime nextDate = new DateTime(year, month, day);

            Console.WriteLine("Workdays for the selected period are {0}.", CountWorkDays(nextDate));

        }
    }
}
