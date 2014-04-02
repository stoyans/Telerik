using System;

namespace Task_7_Strings
{
    class Task_7_Strings
    {
        static void Main()
        {
            string firstPart = "Hello";
            string secondPart = "World";
            object concatenated = firstPart + " " + secondPart;

            string thirdPart = (string)concatenated;

            Console.WriteLine(thirdPart);
        }
    }
}
