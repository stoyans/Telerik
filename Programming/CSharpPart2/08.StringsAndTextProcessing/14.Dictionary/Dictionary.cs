/*A dictionary is stored as a sequence of text lines 
 * containing words and their explanations. 
 * Write a program that enters a word and 
 * translates it by using the dictionary. 
 * Sample dictionary:
.NET – platform for applications from MicrosoftCLR – managed execution environment for .NETnamespace – hierarchical organization of classes*/

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace _14.Dictionary
{
    class Dictionary
    {

        static void Dict()
        {
            Console.Write("enter a word to search: ");
            string word = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            try
            {
                if (dict.ContainsKey(word))
                {
                    Console.WriteLine("{0}", dict[word]);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The word is not in the dictionary!");                                             
            }
        }
        

        static void Main()
        {
            string dictionary = File.ReadAllText(@"..\..\dictionary.txt");

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int index = dictionary.IndexOf(word); //if the word is found we print everything till the end of the line
            while (dictionary[index] != '\r')
            {
                Console.Write(dictionary[index]);
                index++;
            }
            Console.WriteLine();

            //Method with Dictionary structure
            Dict();
        }
    }
}
