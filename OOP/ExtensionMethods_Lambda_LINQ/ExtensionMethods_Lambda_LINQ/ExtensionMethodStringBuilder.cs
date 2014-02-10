using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Lambda_LINQ
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            return str.ToString().Substring(startIndex, length);
        }
    }
}
