/*Write a program that reads a list of words, 
 * separated by spaces and prints the list in an alphabetical order.*/

using System;
using System.Collections.Generic;

namespace SortWordsInAlphabeticalOrder
{
    class MainClass
    {

        static void SortEasier(string[] words)
        {
            SortedSet<string> sortedWords = new SortedSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                sortedWords.Add(words[i]);
            }

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }

        }


        public static void Main()
        {
            string text =
            @"The licenses for most software are designed to take away your
            freedom to share and change it.  By contrast, the GNU General Public
            Licenses are intended to guarantee your freedom to share and change
            free software--to make sure the software is free for all its users.";

            string[] words = text.Split(new[] { ' ', '.', ',', '\t', '\n', '\r', '-' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> uniqueWords = new List<string>(words);

            for (int i = 0; i < uniqueWords.Count; i++)
            {
                string currentWord = uniqueWords[i];

                for (int j = i + 1; j < uniqueWords.Count; j++)
                {
                    if (currentWord == uniqueWords[j])
                    {
                        uniqueWords.Remove(uniqueWords[j]);
                    }
                }

            }
            string[] result = new string[uniqueWords.Count];
            uniqueWords.CopyTo(result);
            Array.Sort(result);

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }

            //Another solution
            Console.WriteLine("ANOTHER SOLUTION");
            Console.WriteLine(new string('*', 20));
            SortEasier(words);

        }
    }
}
