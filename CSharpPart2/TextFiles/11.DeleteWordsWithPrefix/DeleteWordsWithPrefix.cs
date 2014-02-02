/*Write a program that deletes from a text file all 
 * words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DeleteWordsWithPrefix
{
    class DeleteWordsWithPrefix
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\testprefix.txt";
            string text = File.ReadAllText(filePath);
            text = Regex.Replace(text, @"\btest\w+", string.Empty);//regular expression is used to check if some string begins with test
            File.WriteAllText(@"..\..\testprefixtest.txt", text);
        }

        static void Main()
        {
            ReadDate();
        }
    }
}
