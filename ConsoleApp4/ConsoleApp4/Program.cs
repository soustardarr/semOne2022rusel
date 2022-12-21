
using System;

int[] MyArray(int n)
{
    Random random = new Random();
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = random.Next(-10, 10);
    }
    return array;
}

//int MaxIndex(int[] array)
//{
//    int n = array.Length;
//    int maxValue = array[0];
//    int ind = 0;
//    for (int i = n - 1; i < array.Length; i++)
//    {
//        for (int j = 0; j < i; j++)
//        {
//            if (array[j] > maxValue)
//            {
//                maxValue = array[j];
//                ind = j;
//            }
//        }
//    }
//    return ind;
//}


int[] SortSearch(int[] array)
{

    int n = array.Length;
    //for (int i = n - 1; i > 0; i--)
    //{
    for (int j = 0; j < n; j++)
    {
        int maxValue = int.MinValue;
        int ind = 0;
        if (array[j] > maxValue)
        {
            maxValue = array[j];
            ind = j;
        }
        int temp = array[j];
        array[j] = array[ind];
        array[ind] = temp;
    }

    //}
    return array;
}



//int N = 20;
//int[] arr = MyArray(N);
//PrintMas(arr);

////BubbleSort(arr);
//SortSearch(arr);

//PrintMas(arr);




void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}

void BubbleSort(int[] mas)
{
    int n = mas.Length;
    for (int k = n - 1; k > 0; k--)
        for (int i = 0; i < k; i++)
            if (mas[i] > mas[i + 1])
            {
                var t = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = t;
            }
    //bool fl = true;
    //while (fl)
    //{
    //    fl = false;
    //    for (int i = 0; i < n - 1; i++)
    //        if (mas[i] < mas[i + 1])
    //        {
    //            var t = mas[i];
    //            mas[i] = mas[i + 1];
    //            mas[i + 1] = t;
    //            fl = true;
    //        }
    //}

}


//int temp;

//int[] arr = new int[] { 2, 4, 1, 5, 2, 532, 4, 34, 3, 4, 35, 32 };
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] > arr[j])
//        {
//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }
//}
//PrintMas(arr);