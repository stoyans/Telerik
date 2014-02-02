/*We are given a string containing a 
 * list of forbidden words and a 
 * text containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks. 
 * Example:
 * Microsoft announced its next generation PHP compiler today. 
 * It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * Words: "PHP, CLR, Microsoft"
The expected result: ********* announced its next generation *** compiler today. 
 * It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

using System;
using System.Text;

namespace _9.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = 
            "Microsoft announced its next generation PHP compiler today." +
            "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string replaceMicrosoft = "*********";
            string replacePHP = "***";
            string replaceCLR = "***";

            text = text.Replace("Microsoft", replaceMicrosoft);
            text = text.Replace("PHP", replacePHP);
            text = text.Replace("CLR", replaceCLR);

            Console.WriteLine(text);
        }
    }
}
