using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveNumbersOccurOddTimes
{
    class RemoveNumbersOccurOddTimes
    {
        public static void RemoveOddNumberOfTimes(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int numberOfTimes = list.Count(num => num == list[i]);
                if (numberOfTimes %2 != 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            Console.Write(string.Join(" ", list) + '\n');
        }

        public static List<int> FillInNumbers()
        {
            var listOfNumbers = new List<int>();
            Random num = new Random();

            for (int i = 0; i < 10; i++)
            {
                listOfNumbers.Add(num.Next(0, 20));
            }

		    Console.Write(string.Join(" ",listOfNumbers) + '\n');

            return listOfNumbers;

        }
        static void Main()
        {
            RemoveOddNumberOfTimes(FillInNumbers());
        }
    }
}
