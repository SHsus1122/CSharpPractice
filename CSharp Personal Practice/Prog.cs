using System;

namespace CSharp_Personal_Practice
{
    class Prog
    {
        public static void Main(string[] args)
        {
            FifoPractice<int> FifoArray = new FifoPractice<int>();
            FifoArray.Enqueue(1);
            FifoArray.Enqueue(5);
            FifoArray.Enqueue(10);
            FifoArray.Enqueue(15);

            Console.WriteLine("Conatins : " + FifoArray.Contains(15));
            Console.WriteLine("Peek : " + FifoArray.Peek() + ", Count : " + FifoArray.Count());

            FifoArray.Dequeue();
            Console.WriteLine("Conatins : " + FifoArray.Contains(15));
            Console.WriteLine("Peek : " + FifoArray.Peek() + ", Count : " + FifoArray.Count());
        }
    }
}
