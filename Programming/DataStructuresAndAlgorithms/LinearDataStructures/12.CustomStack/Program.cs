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
            stack.Push(6);
            stack.Push(11);
            stack.Push(91);
            stack.Push(31);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            stack.Push(1001);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

        }
    }
}
