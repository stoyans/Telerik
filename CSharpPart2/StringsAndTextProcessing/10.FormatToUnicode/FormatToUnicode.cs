/*Write a program that converts a string to a sequence of 
 * C# Unicode character literals. 
 * Use format strings. Sample input: Hi!
 Expected output: \u0048\u0069\u0021*/

using System;

namespace _10.FormatToUnicode
{
    class FormatToUnicode
    {
        static void Main()
        {
            string expression = "Hi!";

            for (int i = 0; i < expression.Length; i++)
            {
                Console.Write(string.Format("\\u{0:x4}", (int)expression[i]));    
            }
            Console.WriteLine();
            
        }
    }
}
