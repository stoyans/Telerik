/*Write a program that extracts from a given text all sentences containing given word.Example: The word is "in". The text is:
 We are living in a yellow submarine. 
 * We don't have anything else.
 * Inside the submarine is very tight. 
 * So we are drinking all the day. 
 * We will move out of it in 5 days.
 The expected result is:
 We are living in a yellow submarine.We will move out of it in 5 days.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string text =
            "We are living in a yellow submarine. " +
            "We don't have anything else. Inside the submarine is very tight. " +
            "So we are drinking all the day. We will move out of it in 5 days.";

            int startIndex = 0;
            while (text != string.Empty)
            {
                startIndex = text.IndexOf('.', startIndex);
                string sentence = text.Substring(0, startIndex + 1);//extract sentence and checks if there is word "in"

                if (sentence.IndexOf(" in ") != -1)
                {
                    Console.WriteLine(sentence);
                }

                startIndex++;
                text = text.Substring(startIndex);//the text begins from the end of the current sentence till the end of the text
                startIndex = 0;

            }
        }
    }
}
