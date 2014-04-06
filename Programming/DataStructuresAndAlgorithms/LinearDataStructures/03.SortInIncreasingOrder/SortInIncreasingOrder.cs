using System;
using System.Collections.Generic;
using System.Linq;

namespace SortInIncreasingOrder
{
	class MainClass
	{
		public static void Main ()
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
			
			listOfNumbers.Sort();
			
			foreach (var item in listOfNumbers) 
            {
				Console.WriteLine (item);
			}
		}
	}
}
