using System;

namespace _7.GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main()
        {
 
            Console.WriteLine("You will be able to enter 5 numbers");
            double biggest = double.MinValue; //В biggest ще запазим най-голямата въведена стойност. По подразбиране задаваме най-малката стойност, която може да приеме
            //При всяка итерация на цикъл при въведена по-голяма стойност biggest ще я приеме
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                double num = double.Parse(Console.ReadLine());
                if (num >= biggest)
                {
                    biggest = num;
                }
            }

            Console.WriteLine("The biggest number is {0}", biggest);

        }
    }
}
