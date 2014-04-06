using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CustomQueue
{
    public class CustomQueue<T>
    {
        private LinkedList<T> queue;

        public CustomQueue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.queue.AddLast(item);
        }

        public T Peek()
        {
            return this.queue.First.Value;
        }

        public T Dequeue()
        {
            Peek();
            T lastItem = this.queue.First.Value;
            this.queue.RemoveFirst();
            return lastItem;
        }

        public int Count
        {
            get { return this.queue.Count; }
        }
    }
}
