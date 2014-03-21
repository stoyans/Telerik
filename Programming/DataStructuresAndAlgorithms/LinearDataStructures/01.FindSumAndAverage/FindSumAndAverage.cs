using System;
using System.Collections.Generic;
using System.Linq;

namespace FindSumAndAverage
{
	public class Number
	{
		
		public Number (int number)
		{
			Value = number;
		}
			
		public int Value
        {
            get; set;
        }
	}
	
	class MainClass
	{
		public static void Main ()
		{
			var listOfNumbers = new List<int>();

            var list = new List<Number>()
            {
                new Number(5),
                new Number(5),
                new Number(5)
            };
			
			while(true) 
			{
				string symbol = Console.ReadLine();
				
				if (symbol == string.Empty)
				{
					break;
				}
				listOfNumbers.Add(int.Parse(symbol)); 
			}


			Console.WriteLine ("Sum ={0}", listOfNumbers.Sum());
			Console.WriteLine ("Average ={0:F2}", listOfNumbers.Average());
            Console.WriteLine(list.Sum(x=>x.Value));
		}
	}
}
