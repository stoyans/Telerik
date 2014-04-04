/*You are given a text. 
 * Write a program that changes the text in all regions surrounded 
 * by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested. Example:
 We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 The expected result:
 We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

using System;

namespace ChangeToUpper
{
	class MainClass
	{
		
		static void ChangeToUpper (string text)
		{
			int indexStart = 0;
			int indexEnd = 0;
            indexStart = text.IndexOf("<upcase>", indexStart);
            indexEnd = text.IndexOf("</upcase>", indexEnd);

            for (int i = 0; i < text.Length; i++)
            {
                if (i > indexStart + 7 && i < indexEnd) //if the position is 7 symbols after <upcase> and before </upcase>
                {
                    Console.Write(char.ToUpper(text[i]));// To Upper
                }
                else if (i < indexStart || i > indexEnd + 8) //else, just print symbols
                {
                    Console.Write(text[i]);
                }
                if (i > indexEnd + 8)// finds the next appearance of tags
                {
                    indexStart = text.IndexOf("<upcase>", indexStart + 8);
                    indexEnd = text.IndexOf("</upcase>", indexEnd + 9);
                }
            }
            Console.WriteLine();
		}
		
		public static void Main ()
		{
			string expression = 
			"We are living in a <upcase>yellow submarine</upcase>. " +
			"We don't have <upcase>anything</upcase> else.";
			
			ChangeToUpper (expression);
		}
	}
}
