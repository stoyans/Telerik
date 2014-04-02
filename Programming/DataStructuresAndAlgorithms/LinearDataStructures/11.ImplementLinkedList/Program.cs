using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    class Program
    {
        static void Main()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(11);

            Console.WriteLine(list);

        }
    }
}
