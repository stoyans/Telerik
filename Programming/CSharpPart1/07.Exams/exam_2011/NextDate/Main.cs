using System;

	class NextDate
	{
		public static void Main ()
		{
		byte day = byte.Parse(Console.ReadLine());
		byte month = byte.Parse(Console.ReadLine());
		short year = short.Parse(Console.ReadLine());
		
		DateTime nextdate = new DateTime(year, month, day);
		
		Console.WriteLine (nextdate.AddDays(1).ToString("d.M.yyyy"));

		}
	}