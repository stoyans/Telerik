/*Write a program that reads a text file containing a list of strings,  * sorts them and saves them to another text file.  * Example:	Ivan			George	Peter			Ivan	Maria			Maria	George			Peter*/

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace _6.SortStrings
{
    class SortStrings
    {
        static string[] ReadDate()
        {
            const string filePath = @"..\..\strings.txt";
            StreamReader readfile = new StreamReader(filePath);
            List<string> strings = new List<string>();

            string readLine = string.Empty;

            using (readfile)
            {
                while ((readLine = readfile.ReadLine()) != null)
                {
                    strings.Add(readLine);
                }
                readfile.Close();
            }

            return strings.ToArray();
        }

        static string[] Sort(string[] array)
        {
            string temp = null;
            string firstInAlphabet = null;
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i]; //save the value of the first element
                char firstLetter = 'Z';

                for (int j = i; j < array.Length; j++)
                {    
                    char letter = Char.ToUpper(array[j][0]);//saves the first letter in word

                    if (letter <= firstLetter)
                    {
                        position = j; //save the position of the first in alphabet element
                        firstInAlphabet = array[j]; //save the first in alphabet element
                        firstLetter = letter;
                    }
                }
                array[position] = temp; //replace values of the smallest and the current element
                array[i] = firstInAlphabet;
            }
            return array;

        }

        static void FileWrite(string[] array)
        {
            StreamWriter writeToFile = new StreamWriter("..\\..\\resultString.txt", false, Encoding.GetEncoding("windows-1251"));
            foreach (string name in array)
            {
                writeToFile.WriteLine(name);
            }
            writeToFile.Dispose();
        }

        static void Main()
        {
            string[] SortedElements = Sort(ReadDate());
            FileWrite(SortedElements);
        }
    }
}
