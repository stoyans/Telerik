/*Write a program that replaces all occurrences of the substring 
 * "start" with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _7.ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\replace.txt";
            string text = File.ReadAllText(filePath);
            text = text.Replace("start", "finish");
            File.WriteAllText(@"..\..\replaceresult.txt", text); 
        }

        static void Main()
        {
            ReadDate();
        }
    }
}
