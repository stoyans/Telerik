/*Write a program that extracts from a 
 * given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ExtractPolindromes
{
    class ExtractPolindromes
    {
        static void Main()
        {
            string polindromes =
            @"aba acca adda affa aga aha ajaja aka ala alala alula ama amma words other ana
            anana anna apa ara arara atta ava awa bib bob bub dad deed deedeed degged did dod dud ABBA exe jiwagg";

            char[] separators = new char[] { ' ', '\r', '\n', '\\', '/', '.', '!', ',' };
            string[] words = polindromes.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("In the text there are {0} words", words.Length);
            int countpolidromes = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                string reversedword = string.Join("", word);
                if (currentWord == reversedword)
                {
                    countpolidromes++;
                    Console.WriteLine(currentWord);
                }
            }
            Console.WriteLine("And {0} of them are polindromes.", countpolidromes);

        }
    }
}
