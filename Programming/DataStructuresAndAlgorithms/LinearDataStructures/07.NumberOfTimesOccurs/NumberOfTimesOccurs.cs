using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumberOfTimesOccurs
{
    class NumberOfTimesOccurs
    {

        public static void FindNumberOfOccur(int[] list)
        {
            list = list.OrderBy(num => num).ToArray();
            //Console.Write(string.Join(" ", list) + '\n');

            for (int i = 0; i < list.Length; i++)
            {
                int numberOfTimes = list.Count(num => num == list[i]);
                Console.WriteLine("{0} - {1}", list[i], numberOfTimes);
                i += numberOfTimes - 1;
            }
        }

        public static int[] FillInNumbers()
        {
            var listOfNumbers = new int[1000];
            Random num = new Random();

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                listOfNumbers[i] = num.Next(0, 1000);
            }

            Console.Write(string.Join(" ", listOfNumbers) + '\n');

            return listOfNumbers;

        }
        static void Main()
        {
            FindNumberOfOccur(FillInNumbers());
        }
    }
}
