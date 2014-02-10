using System;
using System.Collections.Generic;

namespace GenericList
{
    public class GenericList<T> where T : IComparable
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
            this.capacityDefault = 1;
            this.items = new T[capacityDefault];
        }

        public void Add(T item)
        {
            if (index == items.Length -1)
            {
                IncreaseCapacity();
            }
            this.items[index++] = item;
        }

        public T FindAt(int index)
        {
            if (index > this.index - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index does not exist!");
            }
            return items[index];
        }

        public void RemoveAt(int index)
        {
            if (index > this.index - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index does not exist!");
            }

            for (int i = index; i < this.items.Length; i++)
            {
                index++;
                if (index <= this.items.Length - 1)
                {
                    this.items[i] = this.items[index];
                }
            }
            this.index--;

        }

        public void InsertAt(int index, T element)
        {
            if (index > this.index - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index does not exist!");
            }

            T[] tempList = new T[this.items.Length];
            this.items.CopyTo(tempList, 0);

            for (int i = index + 1; i < this.items.Length; i++)
            {
                this.items[i] = tempList[i - 1];
            }

            this.items[index] = element;
            this.index++;

        }

        public int FindElement(T element)
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                if (element.CompareTo(this.items[i]) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public T Min()
        {
            T min = this.items[0];

            for (int i = 1; i < this.items.Length; i++)
            {
                if (min.CompareTo(this.items[i]) >= 0)
                {
                    min = this.items[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.items[0];

            for (int i = 1; i < this.items.Length; i++)
            {
                if (max.CompareTo(this.items[i]) <= 0)
                {
                    max = this.items[i];
                }
            }

            return max;
        }


        public void Clear()
        {
            this.items = new T[this.capacityDefault];
            this.index = 0;
        }

        public override string ToString()
        {
            for (int i = 0; i < this.index; i++)
            {
                Console.WriteLine(this.items[i]);
            }
            return "";
        }

        private void IncreaseCapacity()
        {
            T[] tempElements = new T[this.items.Length];
            this.items.CopyTo(tempElements, 0);
            this.items = new T[items.Length * 2];
            tempElements.CopyTo(this.items, 0);

        }


    }
}
