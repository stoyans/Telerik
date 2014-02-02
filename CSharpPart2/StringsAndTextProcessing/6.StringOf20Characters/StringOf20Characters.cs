/*Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, 
 * the rest of the characters should be filled with '*'. 
 * Print the result string into the console.*/

using System;

namespace StringOf20Characters
{
	class MainClass
	{
		public static void Main ()
		{
			string characters = string.Empty;

            try
            {
                characters = Console.ReadLine();
                if (characters.Length > 20)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(characters.PadRight(20, '*'));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Enter maximum 20 characters!");
            }
            	
		}
	}
}
