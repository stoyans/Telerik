using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumbersDivisibleBy7and3
{
    class Program
    {
        static void Main()
        {
            int[] intArray = new int[] { 3, 5, 7 , 21, 15, 6};

            //linq
            var divisible = from num in intArray
                            where num % 7 == 0 && num % 3 == 0
                            select num;

            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }

            //lambda

            var divisibleList = intArray.Where(x => x % 21 == 0);
            foreach (var item in divisibleList)
            {
                Console.WriteLine(item);
            }
 

        }
    }
}
