using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CustomStack
{
    public class CustomStack<T>
    {
        private T[] sizeStack;

        public CustomStack()
        {
            this.SizeStack = new T[1];
        }

        private T[] SizeStack
        {
            get { return this.sizeStack; }
            set { this.sizeStack = value; }

        }

        public void Push(T item)
        {
            SizeStack[this.SizeStack.Length - 1] = item;
            Resize();
        }

        public T Pop()
        {
            T lastItem = this.SizeStack[this.SizeStack.Length - 2];
            Remove();
            return lastItem;            
        }

        public T Peek()
        {
            if (this.SizeStack.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty!");
            }
            return this.SizeStack[this.SizeStack.Length - 2];
        }

        private void Resize()
        {
            T[] arrayCopy = new T[SizeStack.Length];
            SizeStack.CopyTo(arrayCopy, 0);
            this.SizeStack = new T[arrayCopy.Length + 1];
            arrayCopy.CopyTo(SizeStack, 0);
        }

        private void Remove()
        {
            T[] arrayCopy = new T[SizeStack.Length - 1];
            for (int i = 0; i < arrayCopy.Length - 1; i++)
            {
                arrayCopy[i] = this.SizeStack[i];
            }
            this.SizeStack = new T[arrayCopy.Length];
            arrayCopy.CopyTo(SizeStack, 0);
        }
    }
}
