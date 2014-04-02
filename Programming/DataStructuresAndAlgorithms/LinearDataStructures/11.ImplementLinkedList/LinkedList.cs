using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    public class CustomLinkedList<T>
    {

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
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(item);
            }
            else
            {
                var addNode = new ListItem<T>(item);
                addNode.NextItem = this.FirstElement;
                this.FirstElement = addNode;
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

        public override string ToString()
        {
            if (this.firstElement == null)
            {
                return string.Format("[ ]");
            }

            StringBuilder sb = new StringBuilder("[ ");

            var currItem = this.firstElement;
            sb.Append(currItem.Value);

            while (currItem.NextItem != null)
            {
                sb.Append(", ");
                sb.Append(currItem.NextItem);
                currItem = currItem.NextItem;
            }

            sb.Append(" ]");

            return sb.ToString();
        }


    }
}
