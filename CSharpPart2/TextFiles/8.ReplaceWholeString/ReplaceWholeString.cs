/*Modify the solution of the previous problem to replace only whole words (not substrings).*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _8.ReplaceWholeString
{
    class ReplaceWholeString
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\replace.txt";
            string text = File.ReadAllText(filePath);
            text = Regex.Replace(text, @"\bstart\b", "finish"); //regular expression is used (if the searched string is like the one
            File.WriteAllText(@"..\..\result.txt", text);       //betweeen \b...\b, it is replaced)
        }

        static void Main()
        {
            ReadDate();
        }
    }
}
