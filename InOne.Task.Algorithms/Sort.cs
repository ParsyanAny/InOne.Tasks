using System;
using InOne.Task.Structure.IMPL;

namespace InOne.Task.Algorithms
{
    public class Sort<T>
         where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            int arrCount = arr.Length;
            for (int i = 0; i < arrCount; i++)
            {
                int count = 0;
                for (int j = 0; j < arrCount - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        swap(arr, j, j + 1);
                        count++;
                    }
                }
                if (count == 0)
                    break;
            }
        }
        public static void InsertionSort(T[] arr)
        {
            int arrCount = arr.Length;
            for (int i = 0; i < arrCount - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) == 1)
                        swap(arr, j, j - 1);
                }
            }
        }
        public static void SelectionSort(T[] arr)
        {
            int smallestIndex;
            int count = arr.Length;
            for (int i = 0; i < count - 1; i++)
            {
                smallestIndex = i;

                for (int index = i + 1; index < count; index++)
                {
                    if (arr[index].CompareTo(arr[smallestIndex]) == -1)
                        smallestIndex = index;
                }
                swap(arr, i, smallestIndex);
            }
        }
        public static void QuickSort(int[] arr)=> quickSort(arr, 0, arr.Length - 1);
        public static void MarginSort(T[] arr)
        {

        }
        public static void HeapSort(T[] arr)
        {

        }
        public static void BuckedSort(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) == 1)
                    max = arr[i];
            }
            int[] ar = new int[max + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                ar[arr[i]]++;
            }
            int index = 0;
            int counter = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                int count = ar[index++];
                while (count > 0)
                {
                    arr[counter++] = i;
                    count--;
                }
            }
        }

        #region private Functionality
        private static void swap(T[] arr, int firstIndex, int secondIndex)
        {
            T temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
        private static void swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
        private static int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        private static void quickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;
            int pivot = array[(left + right) / 2];
            int index = partition(array, left, right, pivot);
            quickSort(array, left, index - 1);
            quickSort(array, index, right);
        }
        #endregion
    }
}

