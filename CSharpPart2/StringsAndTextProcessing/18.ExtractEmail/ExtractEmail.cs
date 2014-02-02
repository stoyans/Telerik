/*Write a program for extracting all email addresses from given text. 
 * All substrings that match the format 
 * <identifier>@<host>…<domain> should be recognized as emails.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18.ExtractEmail
{
    class ExtractEmail
    {
        static void Main()
        {

            string text = File.ReadAllText(@"..\..\email.txt");

            StringBuilder email = new StringBuilder();
            bool prefix = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    email.Append(text[i]);
                    prefix = true;
                }
                //in the first 3 else if blocks we check the symbols which should appear in an email
                //and they are added only if there is prefix(some username)
                else if (text[i] == '@' && prefix == true)
                {
                    email.Append(text[i]);
                }
                else if (text[i] == '.' && prefix == true)
                {
                    email.Append(text[i]);
                }
                else if (text[i] == '_' && prefix == true)
                {
                    email.Append(text[i]);
                }
                //if we meet a symbol different from the above, we check if @ is missing or there are more than one
                else if (email.ToString().IndexOf('@') == -1 || email.ToString().Split('@').Length - 1 > 1)
                {
                    email.Clear();// clear current email
                    prefix = false;
                }
                else
                {
                    string domain = email.ToString().Substring(email.ToString().IndexOf('@') + 1);//extracts the domain

                    if (domain.IndexOf('.') == -1)
                    {
                        email.Clear();//if there isn't '.' symbol email is clear
                    }
                    else if (domain.Substring(0, domain.IndexOf('.')).Length < 2 || domain.Substring(domain.IndexOf('.') + 1) == string.Empty)
                    {
                        email.Clear(); //if the domain length is less than 3 characters, the email is invalid or || we have this situation: test@test.
                    }
                    else
                    {
                        if (email[email.Length - 1] == '.')// if the emails is valid but it contains '.' at the end (left from end of sentence)
                                                           //the last symbol is removed
                        {
                            email.Remove(email.Length - 1, 1);
                        }
                        Console.WriteLine(email); //print the email and the loop begins again
                        prefix = false;
                        email.Clear();
                    }
                }
            }
        }
    }
}
