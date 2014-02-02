/*Write a program that reads a string from the console and 
 * prints all different letters in the string along with 
 * information how many times each letter is found.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.NumberOfLetters
{
    class NumberOfLetters
    {
        static void FindWithDictionary(string text)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsLetter(text[i]))
                {
                   if (letters.ContainsKey(text[i]))
                    {
                        letters[text[i]]++;
                    }
                    else
                    {
                        letters[text[i]] = 1;
                    }
                }
                
            }

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }

        }

        static void Main()
        {
            string text =
            @"The licenses for most software are designed to take away your
            freedom to share and change it.  By contrast, the GNU General Public
            Licenses are intended to guarantee your freedom to share and change
            free software--to make sure the software is free for all its users.";

            /*List<char> letters = new List<char>();
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);

                int count = 0;
                if (text.ToLower().IndexOf(alphabet[i]) != -1)
                {
                    letters.Add(alphabet[i]);

                    for (int j = 0; j < text.Length; j++)
                    {
                        if (alphabet[i] == text.ToLower()[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0} - {1}", alphabet[i], count);
                }

            }  */

            FindWithDictionary(text);
        }
    }
}
