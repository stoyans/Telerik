/*Implement an extension method Substring(int index, int length) 
 * for the class StringBuilder that returns new StringBuilder 
 * and has the same functionality as Substring in the class String.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Lambda_LINQ
{
    class TestProgram
    {
        static void Main()
        {
            string text = "This is some random text!";
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            string a = sb.Substring(2, 12);
            Console.WriteLine(a);
        }
    }

}
