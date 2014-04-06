using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    public class CustomLinkedList<T>
    {
        public int Count
        {
            get
            {
                return GetCount();
            }
            private set { }
        }

        private ListItem<T> firstElement;

        private ListItem<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }
            set
            {
                this.firstElement = value;
            }
        }

        public CustomLinkedList()
        {
            this.FirstElement = null;
        }

        public void AddFirst(T item)
        {

            var addNode = new ListItem<T>(item);
            addNode.NextItem = this.FirstElement;
            this.FirstElement = addNode;

        }

        public void AddLast(T item)
        {
            if (this.firstElement == null)
            {
                this.FirstElement = new ListItem<T>(item);
            }
            else
            {
                ListItem<T> nextElement = this.FirstElement;
                while (nextElement.NextItem != null)
                {
                    nextElement = nextElement.NextItem;
                }

                nextElement.NextItem = new ListItem<T>(item);
            }
        }

        public void RemoveFirst()
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.firstElement = this.firstElement.NextItem;
        }

        private int GetCount()
        {

            if (this.FirstElement == null)
            {
                return 0;
            }
            int countElements = 1;
            ListItem<T> element = this.FirstElement;
            while (element.NextItem != null)
            {
                countElements++;
                element = element.NextItem;
            }

            return countElements;
        }

    }
}
