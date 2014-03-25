using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    public class ListItem<T>
    {

        public ListItem(T value)
        {
            Value = value;
        }

        public T Value
        {
            get;
            set;
        }

        public ListItem<T> NextItem
        {
            get;
            set;
        }
    }
}
