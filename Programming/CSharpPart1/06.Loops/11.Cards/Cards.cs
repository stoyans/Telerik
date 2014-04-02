using System;

namespace _11.Cards
{
    class Cards
    {
        static void Main()
        {

            for (int i = 2; i <= 14; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    if (i > 10)
                    {
                        switch (i)
                        {
                            case 11: Console.Write("Jack ");
                                break;
                            case 12: Console.Write("Queen ");
                                break;
                            case 13: Console.Write("King ");
                                break;
                            case 14: Console.Write("Ace ");
                                break;
                        }
                        switch (k)
                        {
                            case 1: Console.WriteLine("of Spades");
                                break;
                            case 2: Console.WriteLine("of Hearts");
                                break;
                            case 3: Console.WriteLine("of Diamonds");
                                break;
                            case 4: Console.WriteLine("of Clubs");
                                break;
                        }

                    }

                    if (i < 11)
                    {
                        Console.Write("{0} ", i);
                        switch (k)
                        {
                            case 1: Console.WriteLine("of Spades");
                                break;
                            case 2: Console.WriteLine("of Hearts");
                                break;
                            case 3: Console.WriteLine("of Diamonds");
                                break;
                            case 4: Console.WriteLine("of Clubs");
                                break;
                        }
                    }
                    
                }
            }

        }
    }
}
