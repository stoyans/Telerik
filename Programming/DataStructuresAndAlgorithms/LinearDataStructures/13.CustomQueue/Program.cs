using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CustomQueue
{
    class Program
    {
        static void Main()
        {
            Queue<int> abv = new Queue<int>();
            //abv.Pe
            CustomQueue<int> customList = new CustomQueue<int>();
            customList.Enqueue(3);
            customList.Enqueue(5);
            customList.Enqueue(1);
            Console.WriteLine(customList.Dequeue());
            Console.WriteLine(customList.Dequeue());
            customList.Enqueue(12);
            Console.WriteLine(customList.Dequeue());
            Console.WriteLine(customList.Count);
        }
    }
}
