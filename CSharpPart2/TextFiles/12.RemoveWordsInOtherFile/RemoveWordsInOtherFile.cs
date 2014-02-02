/*Write a program that removes from a text file all words 
 * listed in given another text file. Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _12.RemoveWordsInOtherFile
{
    class RemoveWordsInOtherFile
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\testwords.txt";
            const string filePathReplace = @"..\..\test.txt";

            if (!File.Exists(filePath) || !File.Exists(filePathReplace))
            {                               
                throw new FileNotFoundException();
            }

            string text = File.ReadAllText(filePath);
            string textReplace = File.ReadAllText(filePathReplace);
           
            FileInfo fInfo = new FileInfo(filePath);
            FileInfo fInfoReplace = new FileInfo(filePathReplace);

            if (fInfo.IsReadOnly || fInfoReplace.IsReadOnly)
            {
                throw new UnauthorizedAccessException();
            }

            char[] separators = new char[] {' ', '\r', '\n'}; //with these chars we will separate the words
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries is used to remove empty space as a word result

            for (int i = 0; i < words.Length; i++)
            {
                textReplace = textReplace.Replace(words[i], "?????"); //????? marks the place where the words are found.
            }                                                         //to delete them ????? can be replaced with string.empty

            File.WriteAllText(@"..\..\result.txt", textReplace);
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
