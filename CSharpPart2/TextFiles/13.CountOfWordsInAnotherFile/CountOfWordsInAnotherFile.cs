/*Write a program that reads a list of words from a file words.txt 
 * and finds how many times each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and 
 * the words should be sorted by the number of their occurrences in descending order. 
 * Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _13.CountOfWordsInAnotherFile
{
    class CountOfWordsInAnotherFile
    {
        //the task is similar to 12, but this time we count the words and save the result
        static void ReadDate()
        {
            const string filePath = @"..\..\words.txt";
            const string filePathReplace = @"..\..\test.txt";

            if (!File.Exists(filePath) || !File.Exists(filePathReplace))
            {
                throw new FileNotFoundException();
            }

            string text = File.ReadAllText(filePath);
            string textCount = File.ReadAllText(filePathReplace);

            FileInfo fInfo = new FileInfo(filePath);
            FileInfo fInfoReplace = new FileInfo(filePathReplace);

            if (fInfo.IsReadOnly || fInfoReplace.IsReadOnly)
            {
                throw new UnauthorizedAccessException();
            }

            char[] separators = new char[] { ' ', '\r', '\n', '\\', '/', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsToCheck = textCount.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] counter = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < wordsToCheck.Length; j++)
                {
                    if (words[i].ToLower() == wordsToCheck[j].ToLower())
                    {
                        count++;
                    }
                    counter[i] = count;
                }
            }
            Array.Sort(counter, words);
            FileWrite(words, counter);
        }

        static void FileWrite(string[] words, int[] count)
        {
            StreamWriter writeToFile = new StreamWriter("..\\..\\result.txt", true, Encoding.GetEncoding("windows-1251"));
            for (int i = words.Length - 1; i >= 0; i--)
            {
                writeToFile.WriteLine("{0} - {1}", count[i], words[i]);
            }
            
            writeToFile.Dispose();
        }

        static void Main()
        {
            try
            {
                ReadDate();
                Console.WriteLine("Done!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("One or both files were NOT found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Selected files are read-only!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error occured while processing the elements in the text file!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
