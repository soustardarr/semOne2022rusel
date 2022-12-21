using System;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = { 9, 12,34224,32,4,24,3,25,347,568,7,73,2412,4,436,54,7,568,56,834,5, 9, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            Console.ReadLine();
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minInd, int maxInd)
        {
            int temp = 0;
            int pivotInd = minInd - 1;
            for (int i = minInd; i < maxInd; i++)
            {
                if (array[i] < array[maxInd])
                {
                    pivotInd++;
                    temp = array[pivotInd];
                    array[pivotInd] = array[i];
                    array[i] = temp;
                }
            }
            pivotInd++;
            temp = array[pivotInd];
            array[pivotInd] = array[maxInd];
            array[maxInd] = temp;
            return pivotInd;
        }





    }
}

