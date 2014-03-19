using System;
using System.Collections.Generic;
using System.Linq;

namespace FindSumAndAverage
{
	//public class Number
	//{
	//	private int numValue;
	//	
	//	public Number (int number)
	//	{
	//		Value = number;
	//	}
	//		
	//	public int Value {
	//		get {
	//			return this.numValue;
	//		}
	//		set {
	//			this.numValue = value;
	//		}
	//	}
	//}
	
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

            
			Console.WriteLine ("Sum ={0}", sum);
			Console.WriteLine ("Average ={0:F2}", (double)sum/listOfNumbers.Count);
		}
	}
}
