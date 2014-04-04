/*Write a program that reads a text file and prints on the console its odd lines.*/

using System;
using System.IO;

namespace _1.PrintOddLines
{
    class PrintOddLines
    {
        static void Main()
        {
            const string filePath = @"..\..\test.txt";
            StreamReader readFile = new StreamReader(filePath);

            using (readFile)
            {
                int lineCount = 1;

                string lineContent = readFile.ReadLine();

                while (lineContent != null)
                {
                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine("{0} ---> {1}", lineCount, lineContent);
                    }

                    lineCount++;
                    lineContent = readFile.ReadLine();
                }
            }
            readFile.Close();
        }
    }
}
