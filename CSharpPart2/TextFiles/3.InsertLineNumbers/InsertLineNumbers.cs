/*Write a program that reads a text file and inserts line 
 * numbers in front of each of its lines. The result should be written to another text file.*/

using System;
using System.Text;
using System.IO;


namespace _3.InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void FileRead(string path)
        {

            StreamReader readFile = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
            string lineContent = readFile.ReadLine();
            int countLine = 1;

            while (lineContent != null)
            {
                FileWrite(lineContent, countLine);
                lineContent = readFile.ReadLine();
                countLine++;
            }
            readFile.Close();

        }

        static void FileWrite(string contents, int lineNumber)
        {
            StreamWriter writeToFile = new StreamWriter("..\\..\\testresult.txt", true, Encoding.GetEncoding("windows-1251"));
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
        }
    }
}
