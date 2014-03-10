using System;

namespace BInaryDigits
{
    class Program
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
      
            for (int position = 15; position >= 0; position--)
            {
                if ((num >> position & 1) == 0)
                {
                    if (position == 0)
                    {
                        Console.Write("###");
                    }
                    else
                    {
                        Console.Write("###.");
                    }
                    
                    
                }
                else
                {
                    if (position == 0)
                    {
                        Console.Write(".#.");
                    }
                    else
                    {
                        Console.Write(".#..");
                    }
                    
                }
            }
            Console.WriteLine();
            for (int position = 15; position >= 0; position--)
            {
                if ((num >> position & 1) == 0)
                {
                    if (position == 0)
                    {
                        Console.Write("#.#");
                    }
                    else
                    {
                        Console.Write("#.#.");
                    }


                }
                else
                {
                    if (position == 0)
                    {
                        Console.Write("##.");
                    }
                    else
                    {
                        Console.Write("##..");
                    }

                }
            }
            Console.WriteLine();
            for (int position = 15; position >= 0; position--)
            {
                if ((num >> position & 1) == 0)
                {
                    if (position == 0)
                    {
                        Console.Write("#.#");
                    }
                    else
                    {
                        Console.Write("#.#.");
                    }


                }
                else
                {
                    if (position == 0)
                    {
                        Console.Write(".#.");
                    }
                    else
                    {
                        Console.Write(".#..");
                    }

                }
            }
            Console.WriteLine();
            for (int position = 15; position >= 0; position--)
            {
                if ((num >> position & 1) == 0)
                {
                    if (position == 0)
                    {
                        Console.Write("###");
                    }
                    else
                    {
                        Console.Write("###.");
                    }


                }
                else
                {
                    if (position == 0)
                    {
                        Console.Write("###");
                    }
                    else
                    {
                        Console.Write("###.");
                    }

                }
            }
            Console.WriteLine();
        }
    }
}
