using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        static void InsertLast(ref int[] array, int b)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[^1] = b;
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            array = newArray;

        }


        static void HHrheh(params object[] parameters)
        {
            string message = "тип данных {0}, знчание {1}";

            foreach(var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }


        static void func(int a, int b, bool enableLogging = false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("hi");
            }
        }


        static void PrintArray(int[] array, int i = 0)
        {
            if (i <= array.Length)
            {
                Console.WriteLine(array[i]);
                PrintArray(array, i + 1);           
            }
        }
        static int SumArray(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;

            int result = SumArray(array, i + 1);

            return result + array[i];
        }

        static void SumNumber(string number, ref int i, ref int sum)
        {

            if (number.Length == i)
                return;

           
            int a = number[i];
            sum += a;
            i++;
            SumNumber(number, ref i, ref sum);

            
        }


        

        static bool d(int[] tmp, bool res, int st, int last)
        {
            if (!res || last - st <= 1)
            {
                return res;
            }
            if (tmp[st] != tmp[last])
            {
                res = false;
                return d(tmp, res, st, last);
            }
            return d(tmp, res, st + 1, last - 1);
        }


        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3 };
            //int result = SumArray(arr);
            //Console.WriteLine(result);
            //PrintArray(arr, ref i);

            //string number = "561";
            //int i = 0;
            //SumNumber(number, ref i, ref sum);

            //int a = int.MaxValue;

            //try
            //{
            //    int b = checked(a + 1);
            //    Console.WriteLine(b);


            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("ошибка переполнения");

            //}

            //int[] array = new int[] { 3, 4, 3, 4, 4, 3, 2, 1 };

            //Console.WriteLine(SymmetricArray(array, 0, array.Length - 1));

            var g = new[] { 1, 2, 3, 2, 1, 1 };
            Console.WriteLine(d(g, true, 0, g.Length - 1));



        }



    }
}


