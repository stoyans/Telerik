using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main()
        {

            GenericList<int> itemsList = new GenericList<int>();
            itemsList.Add(5);
            itemsList.Add(11);

            Console.WriteLine(itemsList.FindIndex(0));
        }
    }
}
