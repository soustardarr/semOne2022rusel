using System;
using System.Diagnostics.CodeAnalysis;

namespace SelectSort
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item); 
            Console.WriteLine();    
        }

        /// <summary>
        /// слияние двух отсортированных массивов
        /// </summary>
        /// <param name="targetArray"></param>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        static void Merge(int[] targetArray, int[] array1, int[] array2)
        {
            int array1MinInd = 0;
            int array2MinInd = 0;

            int minTargetInd = 0;


            while (array1MinInd < array1.Length && array2MinInd < array2.Length)
            {

                if (array1[array1MinInd] <= array2[array2MinInd])
                {
                    targetArray[minTargetInd] = array1[array1MinInd];
                    array1MinInd++;
                }
                else
                {
                    targetArray[minTargetInd] = array2[array2MinInd];
                    array2MinInd++;
                }
                minTargetInd++;
            }
            while (array1MinInd < array1.Length)
            {
                targetArray[minTargetInd] = array1[array1MinInd];
                array1MinInd++;
                minTargetInd++;

            }
            while (array2MinInd < array2.Length)
            {
                targetArray[minTargetInd] = array2[array2MinInd];
                array2MinInd++;
                minTargetInd++;
            }
        }
        public static void MergeSort(int[] array)
        {
            if (array.Length < 2)
                return;
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int j = mid; j < array.Length; j++)
            {
                right[j - mid] = array[j];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 2, 14, 6, 2 };
            PrintArray(array);

            MergeSort(array);
            Array.Sort(array); 
            PrintArray(array);
        }
    }
}