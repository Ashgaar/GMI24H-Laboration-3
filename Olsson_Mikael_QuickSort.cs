using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Laboration_3a : ILaboration_3_SortingAlgorithmInt
    {
        public void Sort(int[] arr)
        {
            int pivotValue = arr[0];
            int[] temp = new int[arr.Length];

            for(int i = 1; i < arr.Length/2; i++)
            {
                int checkValueLow = arr[i];
                int checkValueHigh = arr[arr.Length - i - 1];

                if (checkValueLow < pivotValue && checkValueHigh > pivotValue)
                {
                    temp[i] = checkValueLow;
                    temp[arr.Length - i - 1] = checkValueHigh;
                }
                
                for(int j = 0; j < temp.Length; j++)
                {
                    Console.WriteLine(temp.Length);
                    Console.WriteLine(temp[j]);
                }
            }
        }
    }
}
