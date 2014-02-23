/*Write a program that reverses the words in given sentence.Example: "C# is not C++, not PHP and not Delphi!" 
 * -> "Delphi not and PHP, not C++ not is C#!".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {

        static void ReverseSentence(string sentence, char end, int[] commas)
        {
            char[] separators = new char[] { ' ', '\r', '\n', '\\', '/', '.', '!', ','};
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                if (commas[i] != 0)
                {
                    Console.Write(words[i] + "," + " ");
                }
                else
                {
                    if (i == words.Length - 1)
                    {
                        Console.Write(words[i]);
                    }
                    else
                    {
                        Console.Write(words[i] + " ");
                    }
                    
                }    
            }
            Console.WriteLine(end);
        }
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            List<int> commas = new List<int>();
            int countEmptySpace = 0;
            //With this loop we count at which consecutive empty space there is comma
            //If comma is found in the list we add the index of the empty space, otherwise we add 0
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    countEmptySpace++;
                    if (sentence[i - 1] == ',')
                    {
                        commas.Add(countEmptySpace);

                    }
                    else
                    {
                        commas.Add(0);
                    }
                }
            }
            commas.Add(0);

            int[] comma = new int[commas.Count];
            commas.CopyTo(comma);
            char sentenceEnd = sentence[sentence.Length -1]; //takes the symbol on which the sentence ends
            ReverseSentence(sentence, sentenceEnd, comma);
        }
    }
}
