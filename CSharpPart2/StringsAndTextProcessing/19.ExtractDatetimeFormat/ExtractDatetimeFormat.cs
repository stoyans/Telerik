/*Write a program that extracts from a given text all dates 
 * that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.*/

using System;
using System.Globalization;

namespace ExtractDatetimeFormat
{
    class MainClass
    {
        public static void Main()
        {
            string text =
            @"I was born at 14.06.1980. My sister was born at 3.7.1984. 
			In 5/1999 I graduated my high school. 
			The law says (see section 7.3.12) 
			that we are allowed to do this (section 7.4.2.9).";

            //extracts the words by the following symbols
            string[] words = text.Split(new[] { ' ', ',', '\t', '\n', '\r', '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Length - 3; i++)
            {
                int dateParse = 0;
                int monthParse = 0;
                int yearParse = 0;
                //tries to parse 3 consecutive numbers which matches the conditions
                if (int.TryParse(words[i], out dateParse) && int.TryParse(words[i + 1], out monthParse) && int.TryParse(words[i + 2], out yearParse))
                {
                    if (dateParse < 32 && dateParse > 0 && monthParse > 0 && monthParse < 13 && yearParse < 9999 && yearParse > 1000)
                    {
                        DateTime time = new DateTime(yearParse, monthParse, dateParse);
                        Console.WriteLine(time.ToString("yyyy-mm-dd", new CultureInfo("en-CA")));
                    }
                }
                
            }

        }
    }
}
