/*Write a program that reads a string from the console 
 * and lists all different words in the 
 * string along with information how many 
 * times each word is found.*/

using System;
using System.Collections.Generic;

namespace CountDifferentWords
{
    class MainClass
    {
        static void FindWithDictionary(string[] words)
        {
            Dictionary<string, int> letters = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (letters.ContainsKey(words[i]))
                {
                    letters[words[i]]++;
                }
                else
                {
                    letters[words[i]] = 1;
                }

            }

            foreach (var word in letters)
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
            HashSet<string> uniqueWords = new HashSet<string>(words); //Hashset adds only unique items
                                                                      //on algorithm in comments below does the same thing, but it's slower
            foreach (var word in words)
            {
                uniqueWords.Add(word);
            }

            //for (int i = 0; i < uniqueWords.Count; i++)
            //{
            //    string currentWord = uniqueWords[i];
            //
            //    for (int j = i + 1; j < uniqueWords.Count; j++)
            //    {
            //        if (currentWord == uniqueWords[j])
            //        {
            //            uniqueWords.Remove(uniqueWords[j]);
            //        }
            //    }
            //
            //}

            foreach (var word in uniqueWords)
            {
                int count = 0;

                for (int j = 0; j < words.Length; j++)
                {
                    if (word == words[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine("{0} - {1}", word, count);
            }
            Console.WriteLine();

            //Solution with Dictionary
            FindWithDictionary(words);
        }
       
    }
}
