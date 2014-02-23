/*Write a program that reads a string from the 
 * console and replaces all series of consecutive 
 * identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".*/

using System;
using System.Text;

namespace ReplaceConsecutiveLettersWithOne
{
    class MainClass
    {
        public static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder resultSequence = new StringBuilder();
            int sequence = 0;

            for (int i = 0; i < text.Length; i += sequence)
            {
                sequence = 0;
                char currentLetter = text[i];

                for (int j = i; j < text.Length; j++)
                {
                    if (text[j] == currentLetter)
                    {
                        sequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                resultSequence.Append(text[i]);
            }

            Console.WriteLine(resultSequence);

        }
    }
}
