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
        public static void QuickSort(T[] arr)=> quickSort(arr, 0, arr.Length - 1);
        public static void MarginSort(T[] arr) => mergeSort(arr, 0, arr.Length-1);
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
        private static int partition(T[] array, int left, int right, T pivot)
        {
            while (left <= right)
            {
                while (array[left].CompareTo(pivot) == - 1)
                {
                    left++;
                }
                while (array[right].CompareTo(pivot) == 1)
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
        private static void quickSort(T[] array, int left, int right)
        {
            if (left >= right)
                return;
            T pivot = array[(left + right) / 2];
            int index = partition(array, left, right, pivot);
            quickSort(array, left, index - 1);
            quickSort(array, index, right);
        }
        private static void merge(T[] arr, int left, int middle, int right)
        {
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

            Array.Copy(arr, left, leftArray, 0, middle - left + 1);
            Array.Copy(arr, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                    arr[k] = rightArray[j++];
                else if (j == rightArray.Length)
                    arr[k] = leftArray[i++];
                else if (leftArray[i].CompareTo(rightArray[j]) < 1)
                    arr[k] = leftArray[i++];
                else
                    arr[k] = rightArray[j++];
            }
        }
        private static void mergeSort(T[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                mergeSort(input, left, middle);
                mergeSort(input, middle + 1, right);
                merge(input, left, middle, right);
            }
        }
        #endregion
    }
}

