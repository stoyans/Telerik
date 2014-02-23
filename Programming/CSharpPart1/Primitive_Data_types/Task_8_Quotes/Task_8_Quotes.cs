using System;

namespace Task_8_Quotes
{
    class Task_8_Quotes
    {
        static void Main()
        {
            string quote_1 = "The \"use\" of quotations causes difficulties.";
            string quote_2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("First string: \n    {0} \nand the second one: \n   {1} ", quote_1, quote_2);

        }
    }
}
