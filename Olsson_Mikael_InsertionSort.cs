using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Mikael_Olsson_InsertionSort : ILaboration_3_SortingAlgorithmInt
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }
    }
}
