/*Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and 
 * prints the date and time after 6 hours and 30 minutes 
 * (in the same format) along with the day of week in Bulgarian.*/

using System;

namespace _17.PrintDateAfter6Hours
{
    class PrintDateAfter6Hours
    {
        static void Main()
        {
            Console.Write("enter the day: ");
            byte day = byte.Parse(Console.ReadLine());
            Console.Write("enter the month: ");
            byte month = byte.Parse(Console.ReadLine());
            Console.Write("enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("enter a hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("enter a minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("enter the seconds: ");
            int seconds = int.Parse(Console.ReadLine());


            DateTime time = new DateTime(year, month, day, hour, minutes, seconds);
            time = time.AddHours(6).AddMinutes(30);
            Console.WriteLine("The time after 6 hours and 30 minutes will be: {0}", time);
            Console.WriteLine(time.ToString("dddd", new System.Globalization.CultureInfo("bg-BG")));
        }
    }
}
