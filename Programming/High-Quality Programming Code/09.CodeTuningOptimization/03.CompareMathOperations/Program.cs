using System;
using System.Diagnostics;

namespace CompareMathOperations
{
    class Program
    {        
        static void Main()
        {
            //Square root
            Console.WriteLine("SQRT Test");
            Stopwatch testWatch = new Stopwatch();
            testWatch.Start();
            Console.WriteLine("Double Tests");
            for (double i = 0; i < 10000; i++)
            {
                Math.Sqrt(i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);
      
            testWatch.Reset();
            Console.WriteLine("Float Tests");
            testWatch.Start();
            for (float i = 0; i < 10000; i++)
            {
                Math.Sqrt(i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);

            testWatch.Reset();
            Console.WriteLine("Decimal Tests");
            testWatch.Start();
            for (decimal i = 0; i < 10000; i++)
            {
                Math.Sqrt((double)i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);

            //Natural Logarithm
            Console.WriteLine("\nNatural Logarithm Test");
            testWatch.Start();
            Console.WriteLine("Double Tests");
            for (double i = 0; i < 10000; i++)
            {
                Math.Log(Math.E, i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);

            testWatch.Reset();
            testWatch.Start();
            Console.WriteLine("Float Tests");
            for (float i = 0; i < 10000; i++)
            {
                Math.Log(Math.E, i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);
            
            testWatch.Reset();
            testWatch.Start();
            Console.WriteLine("Decimal Tests");
            for (decimal i = 0; i < 10000; i++)
            {
                Math.Log(Math.E, (double)i);
            }
            testWatch.Stop();
            Console.WriteLine(testWatch.Elapsed);

        }
        
    }
}
