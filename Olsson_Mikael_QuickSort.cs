using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Mikael_Olsson_QuickSort : ILaboration_3_SortingAlgorithmInt
    {
        public void Sort(int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
        }

        public void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                if ((right - left) <= 10)
                {
                    insertionSort(arr, left, right);
                }
                else
                {
                    int partitionIndex = Partition(arr, left, right);
                    quickSort(arr, left, partitionIndex - 1);
                    quickSort(arr, partitionIndex + 1, right);
                }
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot_middle = (left + right) / 2;
            int temp;

            if (pivot_middle != right)
            {
                temp = arr[pivot_middle];
                arr[pivot_middle] = arr[right];
                arr[right] = temp;
            }

            int pivot = arr[right];
            int lowestIndex = left;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    temp = arr[lowestIndex];
                    arr[lowestIndex] = arr[i];
                    arr[i] = temp;
                    lowestIndex++;
                }
            }

            temp = arr[lowestIndex];
            arr[lowestIndex] = arr[right];
            arr[right] = temp;

            return lowestIndex;
        }


        public void insertionSort(int[] arr, int left, int right)
        {
            int temp;
            for (int i = left; i < right+1; i++)
            {
                for (int j = i; j > left; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
    }
}
