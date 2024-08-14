using System;

namespace CSharp_Personal_Practice
{
    /*
     * Last In First Out, 후입선출
     * 만들어볼 기능
     *  - Push 삽입 / Pop 삭제 / Peek 참조 / Contains 값존재여부 / size 크기확인
     */
    class LifoPractice<T>
    {
        const int DEFAULT_SIZE = 1;     // 생성시 처음으로 할당되는 배열 크기
        const int MULTIPLIER = 2;       // 배열을 얼마나 늘릴지를 결정하는 배율

        T[] ary = new T[DEFAULT_SIZE];

        public int Size;
        private int Capacity { get { return ary.Length; } }

        public void Push(T item)
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

        public void Pop()
        {
            ary[Size - 1] = default(T);
            Size--;
        }

        public T Peek()
        {
            return ary[Size - 1];
        }

        public bool Contains(T item)
        {
            foreach (T ch in ary)
                if (ch.Equals(item)) return true;

            return false;
        }
    }
}
