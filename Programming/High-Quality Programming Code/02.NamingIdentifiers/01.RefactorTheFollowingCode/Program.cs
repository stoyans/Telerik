namespace RefactorTheFollowingCode
{
    using System;

    public class StringOperation
    {
        public const int MAX_COUNT = 6;

        public class StringInput
        {
            public void PrintResult(bool input)
            {
                string inputToString = input.ToString();
                Console.WriteLine(inputToString);
            }
        }

        public static void ReadInput()
        {
            StringOperation.StringInput reader = new StringOperation.StringInput();
            reader.PrintResult(true);
        }
    }

    public class Program
    {
        public static void Main()
        {
            StringOperation.ReadInput();
        }
    }
}
