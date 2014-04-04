/*Write a program that extracts from given XML file all the text without the tags. 
 <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
 * <interest> Games</instrest><interest>C#</instrest><interest> 
 * Java</instrest></interests></student>
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _10.ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void ReadDate()
        {
            const string filePath = @"..\..\xml.txt";
            string text = File.ReadAllText(filePath); // read the whole file
            bool betweenTags = false; //checks if tag begins
            string result = string.Empty; //saves the text between tags

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    betweenTags = true;
                }
                else if (text[i] == '>' && betweenTags == true)
                {
                    betweenTags = false;
                }
                else if (betweenTags == false)
                {
                    //Console.Write("{0}",text[i]);
                    result += text[i];
                }

            }
            Console.WriteLine();
            File.WriteAllText(@"..\..\xmltest.txt", result);
        }

        static void Main()
        {
            ReadDate();
        }
    }
}
