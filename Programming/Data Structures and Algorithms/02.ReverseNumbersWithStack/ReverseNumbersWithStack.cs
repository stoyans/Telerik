using System;
using System.Collections.Generic;

namespace ReverseNumbersWithStack
{
	class MainClass
	{
		public static void Main ()
		{
			var listNumbers = new Stack<int>();
			
			for (int i = 0; i < 4; i++) 
			{
				listNumbers.Push(int.Parse(Console.ReadLine()));
			}
			
			for (int i = 0; i < listNumbers.Count;) 
			{
				Console.WriteLine (listNumbers.Pop());
			}
		}
	}
}
