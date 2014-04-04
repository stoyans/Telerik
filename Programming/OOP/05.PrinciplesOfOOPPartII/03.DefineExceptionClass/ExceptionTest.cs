using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DefineExceptionClass
{
    class ExceptionTest
    {

        static void TestInt()
        {
            int minValue = 1;
            int maxValue = 100;

            int number = int.Parse(Console.ReadLine());
            if (number < minValue || number > maxValue)
            {
                throw new InvalidRangeException<int>("The number is out of range!", minValue, maxValue);
            }
            else
            {
                Console.WriteLine("Entered number is in range");
            }

        }

        static void TestDateTime()
        {
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);

            DateTime date = new DateTime(2012, 2, 1);
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("Date should be between {0} and {1}", start, end);
            }
            else
            {
                Console.WriteLine("Date is correct");
            }
        }

        static void Main()
        {

            try
            {
                TestInt();
                TestDateTime();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }

        }
    }
}
