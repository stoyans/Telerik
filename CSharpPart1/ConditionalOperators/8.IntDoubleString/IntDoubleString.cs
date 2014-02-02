using System;

namespace _8.IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Choose variable \n1.Int \n2.Double \n3.String");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("enter a integer number: ");
                    int varInt = int.Parse(Console.ReadLine());
                    Console.WriteLine("The result is: {0}", varInt+1);
                    break;
                case 2: 
                    Console.Write("enter a floating point number: ");
                    double varDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("The result is: {0}", varDouble + 1);
                    break;
                case 3:
                    Console.Write("enter a string variable number: ");
                    string varString = Console.ReadLine();
                    Console.WriteLine("The result is: {0}", varString + "*");
                    break;
                default: Console.WriteLine("Wrong Input!");
                    break;
            }
        }
    }
}
