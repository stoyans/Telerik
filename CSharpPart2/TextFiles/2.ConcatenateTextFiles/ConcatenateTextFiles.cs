/*Write a program that concatenates two text files into another text file.*/

using System;
using System.IO;
using System.Text;

namespace _2.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {

        static string FileRead(string path)
        {
            StreamReader readFile = new StreamReader(path, Encoding.GetEncoding("windows-1251"));
            string fileContents = readFile.ReadToEnd();
            readFile.Close();

            return fileContents;
        }

        static void FileWrite(string contents)
        {
            StreamWriter writeToFile = new StreamWriter("..\\..\\result.txt", false, Encoding.GetEncoding("windows-1251"));
            writeToFile.Write(contents);
            writeToFile.Dispose();

        }

        static void Main()
        {
            const string firstFilePath = @"..\..\replace.txt";
            const string secondFilePath = @"..\..\strings.txt";

            if (!File.Exists(firstFilePath) || !File.Exists(secondFilePath))
            {
                Console.WriteLine("One of the files or both are not found!");
                return;
            }

            string resultOne = FileRead(firstFilePath); //save the text from the first file
            string resultTwo = FileRead(secondFilePath); //save the text from the second file
            string writeToFile = resultOne + resultTwo;

            FileWrite(writeToFile);

        }
    }
}
