/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/

using System;                      
using System.Collections.Generic;

class CheckIfLeapYear
{
    static int EnterValueForYear()
    {
        Console.Write("Value for year: ");
        int year = int.Parse(Console.ReadLine());

        return year;
    }

    static void LeapYear(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is leap", year);
        }
        else
        {
            Console.WriteLine("Year {0} is NOT leap", year);
        }
    }

    static void Main()
    {
        LeapYear(EnterValueForYear());
    }

}