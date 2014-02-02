using System;

namespace _1.CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            double a = double.Parse(Console.ReadLine()); //amount of money
            double p = double.Parse(Console.ReadLine()); //product price


            double N1tray = n1 * 0.05;
            double N2tray = n2 * 0.1;
            double N3tray = n3 * 0.2;
            double N4tray = n4 * 0.5;
            double N5tray = n5 * 1.00;

            double amount = N1tray + N2tray + N3tray + N4tray + N5tray;

            if (a >= p && amount + p > a)
            {
                Console.WriteLine("Yes {0:F2}", (double)amount + p - a);
            }

            if (a < p)
            {
                double more = p - a;
                Console.WriteLine("More {0:F2}", more);
            }

            if (a > p && amount + p < a)
            {
                Console.WriteLine("No {0:F2}", (double)Math.Abs(amount + p - a));
            }
        }
    }
}
