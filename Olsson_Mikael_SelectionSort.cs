using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Mikael_Olsson_SelectionSort : ILaboration_3_SortingAlgorithmInt
    {
        public void Sort(int[] arr)
        {
            int minimum;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minimum = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minimum])
                    {
                        minimum = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minimum];
                arr[minimum] = temp;
            }
        }
    }
}
