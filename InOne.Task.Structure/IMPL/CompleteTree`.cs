using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure.IMPL
{
    public class CompleteTree<T> : ICompleteTree<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        T[] array;
        private T _root;
        private int lastIndex;
        public CompleteTree(int cap)
        {
            array = new T[cap];
            lastIndex = 0;
        }
        public CompleteTree(T[] arr)
        {
            
        }
        #region Base Functionality
        public void Add(T data)
        {
            if (array.Length - 1 >= lastIndex)
            {
                array[lastIndex] = data;
                int parIndex = getParIndex(lastIndex);
                if (data.CompareTo(array[parIndex]) == -1)
                    HeapifyUp(lastIndex);
                lastIndex++;
                _root = array[0];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public T RemoveMin()
        {
            T temp = array[0];
            array[0] = array[lastIndex - 1];
            array[lastIndex - 1] = default;
            lastIndex--;
            heapifyDown(0);
            _root = array[0];
            return temp;
        }
        public T GetMin() => _root;
        public T[] ToArray()
        {
            T[] arr = new T[array.Length];
            int count = 0;
            foreach (var item in array)
            {
                arr[count++] = item;
            }
            return arr;
        }
        public void Sort()
        {
            int index = 0;
            for (int i = index + 1; i <= index * 2; i++)
            {
                for (int y = index; y <= index * 2; y++)
                {
                    if (y >= array.Length)
                        break;
                    if (array[y].CompareTo(array[y + 1]) == 1)
                        swap(array, y, y + 1);
                }
                if (index == 0)
                    index++;
                index = index * 2;
            }
        }
        #endregion

        #region private Functionality
        private void HeapifyUp(int childIndex)
        {
            int parentIndex = getParIndex(childIndex);
            while (array[childIndex].CompareTo(array[parentIndex]) == -1)
            {
                swap(array, childIndex, parentIndex);
                childIndex = parentIndex;
                parentIndex = getParIndex(childIndex);
            }
        }
        private void heapifyDown(int parentIndex)
        {
            int leftChildIndex = getLeftChildIndex(parentIndex);
            int rightChildIndex = getRightChildIndex(parentIndex);
            while (leftChildIndex != -1 && rightChildIndex != -1)
            {
                if (array[leftChildIndex].CompareTo(array[rightChildIndex]) == -1)
                {
                    swap(array, parentIndex, leftChildIndex);
                    parentIndex = leftChildIndex;
                }
                else
                {
                    swap(array, parentIndex, rightChildIndex);
                    parentIndex = rightChildIndex;
                }
                leftChildIndex = getLeftChildIndex(parentIndex);
                rightChildIndex = getRightChildIndex(parentIndex);
            }
        }
        private int getParIndex(int childIndex) => (childIndex - 1) / 2;
        private int getLeftChildIndex(int parentIndex)
            => (2 * parentIndex + 1) <= lastIndex - 1 ? 2 * parentIndex + 1 : -1;
        private int getRightChildIndex(int parentIndex)
            => (2 * parentIndex + 2) <= lastIndex - 1 ? 2 * parentIndex + 2 : -1;
        private void swap(T[] arr, int firstIndex, int secondIndex)
        {
            T temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
        #endregion

        #region Enumerator
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in array)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion
    }
}
