/*Write a program that extracts from given 
 * HTML file its title (if available), 
 * and its body text without the HTML tags. Example:*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _10.ExtractTextFromHTML
{
    class _10ExtractTextFromHTML
    {
        static void ExtractTextFromHTML()
        {
            string text = @"<html>
            <head><title>News</title></head>
            <body><p><a href=http://academy.telerik.com\>Telerik
            Academy</a>aims to provide free real-world practical
            training for young people who want to turn into
            skillful .NET software engineers.</p></body>
            </html>";
            bool betweenTags = false; 

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
                    Console.Write(text[i]);
                }

            }
        }

        static void Main()
        {
            ExtractTextFromHTML();
        }
    }
}
