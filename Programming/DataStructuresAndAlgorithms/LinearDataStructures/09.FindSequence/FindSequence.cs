using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FindSequence
{
    class FindSequence
    {
        static void Main()
        {
            int N = 2;
            var sequence = new Queue<int>();
            sequence.Enqueue(N);
            int count = 0;

            while (count < 50)
            {
                int currentNum = sequence.Dequeue();
                count++;
                Console.WriteLine("{0} -> {1}", count, currentNum);
                sequence.Enqueue(currentNum + 1);
                sequence.Enqueue(2 * currentNum + 1);
                sequence.Enqueue(currentNum + 2);
            }

        }
    }
}
