using System;

namespace InOne.Task.Algorithms
{
    public class Sort<T>
         where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            int count = arr.Length;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                        Swap(arr, j, j + 1);
                }
            }
        }
        public static void InsertionSort(T[] arr)
        {
            int count = arr.Length;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) == 1)
                        Swap(arr, j, j - 1);
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
                Swap(arr,i, smallestIndex);
            }
        }
        public static void Swap(T[] arr, int firstIndex, int secondIndex)
        {
            T temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
