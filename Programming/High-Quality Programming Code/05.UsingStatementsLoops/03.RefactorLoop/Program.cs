namespace RefactorLoop
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = new int[100];
            int expectedValue = 0;
            bool foundValue = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        foundValue = true;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            if (foundValue)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
