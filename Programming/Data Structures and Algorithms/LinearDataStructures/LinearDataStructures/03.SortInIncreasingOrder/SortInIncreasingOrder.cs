using System;
using System.Collections.Generic;

namespace SortInIncreasingOrder
{
	class MainClass
	{
		public static void Main ()
		{
			var listOfNumbers = new List<int>();
			long sum = 0;
			
			while(true) 
			{
				string symbol = Console.ReadLine();
				
				if (symbol == string.Empty)
				{
					break;
				}
				sum += int.Parse(symbol);
				listOfNumbers.Add(int.Parse(symbol)); 
			}
			
			listOfNumbers.Sort();
			
			foreach (var item in listOfNumbers) {
				Console.WriteLine (item);
				
			}
		}
	}
}
