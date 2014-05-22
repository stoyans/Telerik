namespace RefactorCodeVariableUsage
{
    using System;

    public class Statistics
    {
        public static void Main()
        {
        }

        public void PrintStatistics(double[] numbers, int count)
        {
            double maxElement = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }

            double minElement = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < minElement)
                {
                    minElement = numbers[i];
                }
            }

            double numbersSum = 0;

            for (int i = 0; i < count; i++)
            {
                numbersSum += numbers[i];
            }

            double average = numbersSum / count;

            this.PrintResult(maxElement);
            this.PrintResult(minElement);
            this.PrintResult(average);
        }

        public void PrintResult(double value) 
        {
            Console.WriteLine(value);
        }
    }
}
