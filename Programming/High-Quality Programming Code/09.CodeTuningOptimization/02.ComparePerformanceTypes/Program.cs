using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ComparePerformanceTypes
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            //Add scripts
            stopwatch.Start();
            int addToIntSum = 0;
            for (int i = 0; i < 100; i++)
            {
                addToIntSum += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Sum of 100 Int took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            long addToLongSum = 0;
            for (long i = 0; i < 100; i++)
            {
                addToLongSum += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Sum of 100 Long took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            float addToFloatSum = 0;
            for (float i = 0; i < 100; i++)
            {
                addToFloatSum += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Sum of 100 Float took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            double addToDoubleSum = 0;
            for (double i = 0; i < 100; i++)
            {
                addToDoubleSum += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Sum of 100 Double took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            decimal addToDecimalSum = 0m;
            for (decimal i = 0; i < 100; i++)
            {
                addToDecimalSum += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Sum of 100 Decimal took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();


            //Subtract scripts
            stopwatch.Start();
            addToIntSum = 0;
            for (int i = 0; i < 100; i++)
            {
                addToIntSum -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Subtract of 100 Int took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToLongSum = 0;
            for (long i = 0; i < 100; i++)
            {
                addToLongSum -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Subtract of 100 Long took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToFloatSum = 0;
            for (float i = 0; i < 100; i++)
            {
                addToFloatSum -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Subtract of 100 Float took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDoubleSum = 0;
            for (double i = 0; i < 100; i++)
            {
                addToDoubleSum -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Subtract of 100 Double took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDecimalSum = 0m;
            for (decimal i = 0; i < 100; i++)
            {
                addToDecimalSum -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Subtract of 100 Decimal took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            //Multiply scripts
            stopwatch.Start();
            addToIntSum = 1;
            for (int i = 1; i < 10; i++)
            {
                addToIntSum *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Multiply of 10 Int took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToLongSum = 1;
            for (long i = 1; i < 10; i++)
            {
                addToLongSum *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Multiply of 10 Long took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToFloatSum = 1;
            for (float i = 1; i < 10; i++)
            {
                addToFloatSum *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Multiply of 10 Float took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDoubleSum = 1;
            for (double i = 1; i < 10; i++)
            {
                addToDoubleSum *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Multiply of 10 Double took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDecimalSum = 1m;
            for (decimal i = 1; i < 10; i++)
            {
                addToDecimalSum *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Multiply of 10 Decimal took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            //Divide scripts
            stopwatch.Start();
            addToIntSum = 1;
            for (int i = 1; i < 10; i++)
            {
                addToIntSum /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Divide of 10 Int took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToLongSum = 1;
            for (long i = 1; i < 10; i++)
            {
                addToLongSum /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Divide of 10 Long took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToFloatSum = 1;
            for (float i = 1; i < 10; i++)
            {
                addToFloatSum /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Divide of 10 Float took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDoubleSum = 1;
            for (double i = 1; i < 10; i++)
            {
                addToDoubleSum /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Divide of 10 Double took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            addToDecimalSum = 1m;
            for (decimal i = 1; i < 10; i++)
            {
                addToDecimalSum /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Divide of 10 Decimal took: {0}", stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
