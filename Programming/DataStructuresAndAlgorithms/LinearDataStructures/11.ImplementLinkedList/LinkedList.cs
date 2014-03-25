using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    public class LinkedList<T>: IEnumerable<T>
    {

        public ListItem<T> FirstElement
        {
            get;
            set;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //for (var current = this.First; current != null; current = current.Next)
            //    yield return current.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
