using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CustomStack
{
    public class CustomStack<T>
    {

        private int size;
        private T[] sizeStack;

        public CustomStack()
        {
            this.Size = 0;
            this.SizeStack = new T[2];
        }

        private T[] SizeStack 
        {
            get { return this.sizeStack; }
            set { this.sizeStack = value; }
            
        }

        private int Size
        {
            get;
            set;
        }

        public void Push(T item)
        {
            
            SizeStack[size] = item;
            size++;

        }

        public T Pop()
        {
            if (this.SizeStack.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.SizeStack[size--];
        }

        private void Resize()
        {
            
        }
    }
}
