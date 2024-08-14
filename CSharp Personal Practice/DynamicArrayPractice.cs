using System;

namespace CSharp_Personal_Practice
{
    class DynamicArrayPractice<T>
    {
        const int DEFAULT_SIZE = 1;     // 생성시 처음으로 할당되는 배열 크기
        const int MULTIPLIER = 2;       // 배열을 얼마나 늘릴지를 결정하는 배율

        T[] ary = new T[DEFAULT_SIZE];

        public int Count;   // 배열 원소의 개수
        public int Capacity { get { return ary.Length; } }  // 배열에 할당된 크기

        /*
         * MULTIPLIER 를 통해서 배열의 크기가 증가해야 할 경우 이처럼 2배수로 늘리는 이유는 성능 최적화가 목적입니다.
         * 이는 O(n) 복잡도의 배열 복사 작업이 덜 빈번하게 발생하게 되어 성능 개선이 가능합니다.
         * 만약 Add 할 때마다 배열의 사이즈를 1 씩 늘리게 되면 추가할 때마다 배열 크기 조정이 발생하게 되어 성능에 영향을 미칠수 있기 때문입니다.
         */
        public void Add(T item)
        {
            // 배열이 가득 찬 경우, 배열 크기 증가
            if (Count >= Capacity)
            {
                T[] newAry = new T[Capacity * MULTIPLIER];

                // 기존 원소들을 새 배열로 복사
                for (int i = 0; i < Count; i++)
                    newAry[i] = ary[i];

                ary = newAry;
            }

            // 새로운 원소 추가
            ary[Count] = item;
            Count++;
        }

        // 인덱스로 접근
        public T this[int index]
        {
            get { return ary[index]; }
            set { ary[index] = value; }
        }

        // 인덱스 위치의 값 삭제 후 뒤의 원소 이동
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                ary[index] = ary[index + 1];

            // 마지막 원소를 dafault 값으로 변환 int 자료형의 경우 0으로 초기화 된다.
            ary[Count - 1] = default(T);
            Count--;    // 배열 크기 재조정
        }
    }
}
