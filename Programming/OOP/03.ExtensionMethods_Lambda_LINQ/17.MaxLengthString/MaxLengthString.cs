using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MaxLengthString
{
    class MaxLengthString
    {
        static void Main()
        {
            string[] strings = new string[]
            {
                "Word", "something","went","sentence" 
            };

            var bestLen = strings.OrderByDescending(str => str.Length).First();
            Console.WriteLine(bestLen);
        }
    }
}
