using System;

namespace Structures.PriorityQueues
{
    public class BinaryHeap<T>
        where T : IComparable<T>
    {
        private T[] elements;
        private int lastIndex;

        public BinaryHeap(int capacity)
        {
            this.Capacity = capacity;
            this.elements = new T[this.Capacity];
            this.lastIndex = 0;
        }

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                return this.lastIndex;
            }
        }

        public void Enqueue(T element)
        {
            this.elements[this.lastIndex] = element;
            this.HeapifyUp(element, this.lastIndex);
            this.lastIndex++;

            if (this.lastIndex == this.Capacity)
            {
                this.Resize();
            }
        }

        public T Dequeue()
        {
            var element = this.elements[0];
            this.elements[0] = this.elements[this.lastIndex - 1];

            this.HeapifyDown(this.elements[0], 0);
            this.lastIndex--;

            return element;
        }

        private void HeapifyDown(T element, int index)
        {
            var currIndex = index;

            var smallerChildIndex = this.GetSmallerChildIndex(currIndex);

            while (currIndex < ((this.lastIndex - 1) / 2) && element.CompareTo(this.elements[smallerChildIndex]) > 0)
            {
                this.elements[currIndex] = this.elements[smallerChildIndex];
                currIndex = smallerChildIndex;

                smallerChildIndex = this.GetSmallerChildIndex(currIndex);
            }

            this.elements[currIndex] = element;
        }

        private int GetSmallerChildIndex(int parentIndex)
        {
            var leftChildIndex = (parentIndex * 2) + 1;
            var rightChildIndex = (parentIndex * 2) + 2;
            if (rightChildIndex == this.lastIndex)
            {
                rightChildIndex = leftChildIndex;
            }

            var smallerChildIndex = leftChildIndex;
            if (leftChildIndex < this.lastIndex && this.elements[leftChildIndex].CompareTo(this.elements[rightChildIndex]) > 0)
            {
                smallerChildIndex = rightChildIndex;
            }

            return smallerChildIndex;
        }

        private void HeapifyUp(T element, int index)
        {
            var currIndex = index;
            var parentIndex = (currIndex - 1) / 2;
            while (currIndex >= 1 && element.CompareTo(this.elements[parentIndex]) < 0)
            {
                this.elements[currIndex] = this.elements[parentIndex];
                currIndex = parentIndex;
                parentIndex = (currIndex - 1) / 2;
            }

            this.elements[currIndex] = element;
        }

        private void Resize()
        {
            this.Capacity *= 2;
            var newArr = new T[this.Capacity];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newArr[i] = this.elements[i];
            }

            this.elements = newArr;
        }
    }
}
