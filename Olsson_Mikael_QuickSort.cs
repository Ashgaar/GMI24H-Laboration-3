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
            int pivot = arr[(left + right) / 2];
            int lowestIndex = (left - 1);
            int temp;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    lowestIndex++;
                    temp = arr[lowestIndex];
                    arr[lowestIndex] = arr[i];
                    arr[i] = temp;
                }
            }
            temp = arr[lowestIndex + 1];
            arr[lowestIndex + 1] = arr[pivot+1];
            arr[pivot+1] = temp;

            return lowestIndex + 1;
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
