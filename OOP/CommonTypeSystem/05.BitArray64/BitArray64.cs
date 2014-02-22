using System;
using System.Collections;
using System.Collections.Generic;

namespace _05.BitArray64
{
    class BitArray64 : IEnumerable<int>
    {

        private int[] bitArray = new int[64];
        private ulong number;

        public ulong Number
        {
            get { return this.number; }
            private set { this.number = value; }
        }

        public BitArray64(ulong number)
        {
            this.Number = number;

            for (int i = 0; i < 64; i++)
            {
                bitArray[i] = (int)(number % 2);
                number /= 2;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.bitArray;
            for (int i = 63; i >= 0; i--)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
            {
                return false;
            }

            BitArray64 other = obj as BitArray64;
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return this.Number == other.Number;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.bitArray;
                return bits[index];
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BitArray64 firstNum, BitArray64 secondNum)
        {
            return firstNum.Equals(secondNum);
        }

        public static bool operator !=(BitArray64 firstNum, BitArray64 secondNum)
        {
            return !(firstNum == secondNum);
        }
    }
}
