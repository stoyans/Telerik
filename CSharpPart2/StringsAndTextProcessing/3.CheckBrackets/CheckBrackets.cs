/*Write a program to check if in a given expression the brackets are put correctly.Example of correct expression: ((a+b)/5-d).Example of incorrect expression: )(a+b)).*/

using System;

namespace CheckBrackets
{
	class MainClass
	{
		
		static void CheckBrackets(string expression)
		{
			int countLeftBracket = 0;
			int countrightBracket = 0;
			
			for (int i = 0; i < expression.Length; i++) 
			{
				if (expression[i] == '(') 
				{
					countLeftBracket++;
				}
				if (expression[i] == ')') 
				{
					countrightBracket++;
				}
			}
			if (countLeftBracket == countrightBracket) 
			{
				Console.WriteLine ("Expression is correct!");	
			}
			else
			{
				Console.WriteLine ("Incorrect expression!");
			}
			
		}
		
		public static void Main ()
		{
			string expression = ")(a+b)/5-d)";
			CheckBrackets(expression);
		}
	}
}
