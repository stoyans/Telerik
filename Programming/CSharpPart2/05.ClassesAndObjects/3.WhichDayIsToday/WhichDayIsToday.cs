/*Write a program that prints to the console which day of the week is today. Use System.DateTime.*/

using System;
using System.Collections.Generic;

class WhichDayIsToday
{
	
	static void DayOfTheWeek()
	{
		Console.WriteLine ("Today is {0}", DateTime.Today.DayOfWeek);
	}
	
	static void Main ()
	{
		DayOfTheWeek();
	}
}