using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace SimpleCode
{
    class Program
    {

        static void Resize1<T>(ref T[] array, int n)
        {
            T[] newArray = new T[n];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void ArrayAdd(ref int[] array, int ind, int number)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[ind] = number;

            for (int i = 0; i < ind; i++)
                newArray[i] = array[i];
            
            
            for (int i = ind; i < array.Length; i++)
               newArray[i + 1] = array[i];
            
            
            array = newArray;
        }

        static void InsertFirst(ref int[] array, int b)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = b;
            for (int i = 0; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;
        }

        static void InsertLastOf(ref int[] array, int b)
        {
            int[] newArray = new int[array.Length + 1];
            Index ind = 
            newArray[1] = b;

        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 4 };
            int ind = 5;
            int numer = 121;
            //ArrayAdd(ref arr, ind, numer);
            InsertFirst(ref arr, ind);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            //Resize1(ref arr, 12);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}






        }



    }
}


