using System;
using System.Collections.Generic;

namespace GenericList
{
    public class GenericList<T>
    {
        private int capacityDefault;
        private T[] items;
        private int index = 0;

        public GenericList(int capacity)
        {
            this.capacityDefault = capacity;
            this.items = new T[capacity];
        }
        public GenericList()
        {
            this.capacityDefault = 12;
            this.items = new T[capacityDefault];
        }

        public void Add(T item)
        {
            //if middle to double size
            this.items[index] = item;
            index++;
        }

        public T FindIndex(int index)
        {
            //check if index is out of range
            return items[index];
        }

    }
}
