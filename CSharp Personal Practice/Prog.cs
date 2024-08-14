using System;

namespace CSharp_Personal_Practice
{
    class Prog
    {
        public static void Main(string[] args)
        {
            DynamicArrayPractice<int> dArray = new DynamicArrayPractice<int>();
            dArray.Add(1);
            dArray.Add(5);
            dArray.Add(10);
            dArray.Add(15);

            for (int i = 0; i < dArray.Count; i++)
                Console.WriteLine(dArray[i]);

            dArray.RemoveAt(1);
            Console.WriteLine();

            for (int i = 0; i < dArray.Count; i++)
                Console.WriteLine(dArray[i]);
        }
    }
}
