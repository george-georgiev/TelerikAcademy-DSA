using Structures.PriorityQueues;
using System;

namespace ConsoleClient
{
    public class BinaryHeapTester
    {
        public void Test()
        {
            Console.WriteLine("Binary Heap Test");
            var numbers = new int[] { 8, 1, 5, 2, 9, 7, 6, 3, 4, 1, 4, 8 };
            var binaryHeap = new BinaryHeap<int>(numbers.Length);

            Console.WriteLine(string.Join(" ", numbers));

            foreach (var num in numbers)
            {
                binaryHeap.Enqueue(num);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", binaryHeap.Dequeue());
            }

            Console.WriteLine();
        }
    }
}
