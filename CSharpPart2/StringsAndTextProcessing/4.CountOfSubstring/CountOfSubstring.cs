/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
Example: The target substring is "in". The text is as follows:
 We are living in an yellow submarine. 
 * We don't have anything else. 
 * Inside the submarine is very tight. 
 * So we are drinking all the day. 
 * We will move out of it in 5 days.*/

using System;

namespace CountOfSubstring
{
    class MainClass
    {

        static int CountSubstring(string text)
        {
            int countIN = 0;
            int index = 0;

            while (index != -1)
            {
                index = text.IndexOf("in", index + 2);
                countIN++;
            }

            return countIN;
        }

        public static void Main()
        {
            string text =
                "We are living in an yellow submarine. We don't have anything else. " +
                "Inside the submarine is very tight. So we are drinking all the day. " +
                "We will move out of it in 5 days.";

            Console.WriteLine(" Substring \"in\" is found {0} time(s).", CountSubstring(text));

        }
    }
}
