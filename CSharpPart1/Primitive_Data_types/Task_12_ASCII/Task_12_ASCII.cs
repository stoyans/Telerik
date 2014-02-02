using System;

namespace Task_12_ASCII
{
    class Task_12_ASCII
    {
        static void Main()
        {
            for (byte i = 0; i < 128; i++)
            {
                if (char.IsWhiteSpace((char)i))
                {
                    if ((char)i == '\t')
                    {
                        Console.WriteLine("\\t");
                    }
                    if ((char)i == ' ')
                    {
                        Console.WriteLine("space");
                    }
                    if ((char)i == '\n')
                    {
                        Console.WriteLine("\\n");
                    }
                    if ((char)i == '\r')
                    {
                        Console.WriteLine("\\r");
                    }
                    if ((char)i == '\v')
                    {
                        Console.WriteLine("\\v");
                    }
                    if ((char)i == '\f')
                    {
                        Console.WriteLine("\\f");
                    }
                }
                else if (char.IsControl((char)i))
                {
                    Console.WriteLine("control");
                }
                else
                {
                    Console.WriteLine((char)i);
                }

            }
        }
    }
}
