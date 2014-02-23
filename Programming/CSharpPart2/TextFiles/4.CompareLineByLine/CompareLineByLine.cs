/*Write a program that compares two text files line by line 
 * and prints the number of lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _4.CompareLineByLine
{
    class CompareLineByLine
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\test.txt";
            const string filePath2 = @"..\..\test2.txt";
            StreamReader readfile = new StreamReader(filePath);
            StreamReader readfile2 = new StreamReader(filePath2);
            int countLines = 1;
            
            string readLine = string.Empty;
            string readLine2 = string.Empty;


            using (readfile)
            {
                while ((readLine = readfile.ReadLine()) != null && (readLine2 = readfile2.ReadLine()) != null)
                {
                    if (readLine == readLine2)
                    {
                        Console.WriteLine("Line {0} in both files is the same", countLines);
                    }
                    else
                    {
                        Console.WriteLine("Line {0} in both files is different", countLines);
                    }
                    countLines++;
                }
                readfile.Close();
            }
        }

        static void Main()
        {
            ReadDate();
        }
    }
}
