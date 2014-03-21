using System;
using System.Collections.Generic;

namespace RemoveNegativeNumbers
{
	class MainClass
	{
		
		public static void RemoveNegative(List<int> nums)
		{
			nums.RemoveAll(x => x < 0);
			
			foreach (int item in nums) 
			{
				Console.WriteLine (item);
			}
		}
		
		public static List<int> FillInNumbers()
		{
			var listOfNumbers = new List<int>();
			
			while(true) 
			{
				string symbol = Console.ReadLine();
				
				if (symbol == string.Empty)
				{
					break;
				}
				listOfNumbers.Add(int.Parse(symbol)); 
			}
			
			return listOfNumbers;
		}
		
		public static void Main ()
		{
			RemoveNegative(FillInNumbers());
		}
	}
}
