/*Describe the strings in C#. 
 * What is typical for the string data type? 
 * Describe the most important methods of the String class.*/

using System;

namespace DescribeCStrings
{
	class MainClass
	{
		public static void Main ()
		{
			//Strings in C# are sequence of char elements.
			//Each element can be found by the number of its index
			//Strings are read-only and are saved in dynamic memory (managed heap).
			//We can NOT change strings, new results are saved in another part of the memory
			//in different variable.

            //1. Concatenates 2 strings ( string.Concat(str1, str2) )
            //2. Convert to uppercase ( text.ToUpper() )
            //3. Convert to lowercase ( text.ToLower() )
            //4. Substring - get the first 10 characters ( text.Substring(0,10) )
            //5. Remove leading or trailing whitespace ( text.Trim() )
            //6. Split String by a char ( text.Split(' ') )
            //7. Finding the index of a element(or string) ( text.IndexOf(“searchedText”) )
            //9. Checks if two reference vars are equal ( object.ReferenceEquals(str1 , str2) )
            //10. Get lenght of the string ( text.Length )
            //11. Replacing text in string ( text. Replace(“this”,”that”) )
            //12. Comparison string.Compare(string1 , string2) or string1.CompareTo(string2)
		}
	}
}
