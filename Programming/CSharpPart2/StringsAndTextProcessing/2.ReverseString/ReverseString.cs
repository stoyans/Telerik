/*Write a program that reads a string,  * reverses it and prints the result at the console.Example: "sample" -> "elpmas".*/

using System;
using System.Text;

namespace ReverseString
{
	class MainClass
	{
		
		static string ReverseString(string readString)
		{
			
			StringBuilder stringToWrite = new StringBuilder();
			
			for (int i = readString.Length - 1; i >= 0; i--) 
			{
				stringToWrite.Append(readString[i]);
			}
			
			return stringToWrite.ToString();
		}
		
		public static void Main (string[] args)
		{
			
			string stringToRead = "Alphabet";
			Console.WriteLine (ReverseString(stringToRead));
			
		}
	}
}
