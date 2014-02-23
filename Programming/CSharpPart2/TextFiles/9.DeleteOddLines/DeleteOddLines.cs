/*Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _9.DeleteOddLines
{
    class DeleteOddLines
    {
        static void FileRead(string path)
        {

            StreamReader readFile = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
            string lineContent = readFile.ReadLine();
            int countLine = 1;

            while (lineContent != null)
            {
                if (countLine % 2 == 0)
	            {
                    FileWrite(lineContent, countLine);
	            }
                lineContent = readFile.ReadLine();
                countLine++;
            }
            readFile.Close();

        }

        static void FileWrite(string contents, int lineNumber)
        {
            StreamWriter writeToFile = new StreamWriter("..\\..\\temp.txt", true, Encoding.GetEncoding("windows-1251"));
            writeToFile.Write("{0}.", lineNumber);
            writeToFile.WriteLine(contents);
            writeToFile.Dispose();

        }

        static void Main()
        {
            const string filePath = @"..\..\test.txt"; ;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("One of the files or both are not found!");
                return;
            }

            FileRead(filePath);
            string text = File.ReadAllText(@"..\..\temp.txt");
            File.WriteAllText(@"..\..\test.txt", text);
            File.Delete(@"..\..\temp.txt");
        }
    }
}
