using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(3);
            Console.WriteLine(stack.Pop());

            //Stack<int> dwada = new Stack<int>();
            //dwada.Peek()
        }
    }
}
