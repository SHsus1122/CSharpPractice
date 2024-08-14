using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Personal_Practice
{
    class FifoPractice<T>
    {
        const int DEFAULT_SIZE = 1;
        const int MULTIPLIER = 2;

        T[] ary = new T[DEFAULT_SIZE];

        private int Size;
        private int Capacity {  get { return ary.Length; } }

        public void Enqueue(T item)
        {
            if (Size >= Capacity)
            {
                T[] newAry = new T[Capacity * MULTIPLIER];

                for (int i = 0; i < Size; i++)
                    newAry[i] = ary[i];

                ary = newAry;
            }

            ary[Size] = item;
            Size++;
        }

        public void Dequeue()
        {
            for (int i = 0; i < Size; i++)
            {
                if (i == (Size - 1)) ary[i] = default(T);
                else ary[i] = ary[i + 1];
            }

            Size--;
        }

        public int Count()
        {
            return Size;
        }

        public T Peek()
        {
            return ary[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Size; i++)
                if (ary[i].Equals(item)) return true;

            return false;
        }
    }
}
