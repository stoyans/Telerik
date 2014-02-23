using System;

namespace _10.BonusScores
{
    class Program
    {
        static void Main()
        {
            int digit = 0;
            string value = null;

            while (!int.TryParse (value, out digit))
            {
                Console.Write("enter a value between 1 - 9: ");
                value = Console.ReadLine();
            }

            switch (digit)
            {
                case 1: 
                case 2: 
                case 3: Console.WriteLine("the value multiplied by 10 is: {0}", digit * 10);
                    break;
                case 4: 
                case 5: 
                case 6: Console.WriteLine("the value multiplied by 100 is: {0}", digit * 100);
                    break;
                case 7: 
                case 8: 
                case 9: Console.WriteLine("the value multiplied by 1000 is: {0}", digit * 1000);
                    break;
                default: Console.WriteLine("Wrong Input!");
                    break;
            }
        }
    }
}
