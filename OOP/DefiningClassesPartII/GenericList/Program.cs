using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            try
            {
                GenericList<int> itemsList = new GenericList<int>();
                itemsList.Add(5);
                itemsList.Add(11);
                itemsList.Add(2);
                itemsList.Add(-4);

                itemsList.InsertAt(1, 9);
                Console.WriteLine(itemsList.FindAt(1));
                Console.WriteLine(itemsList.FindElement(15));
                Console.WriteLine(itemsList.Min());
                Console.WriteLine(itemsList.Max());
                itemsList.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
