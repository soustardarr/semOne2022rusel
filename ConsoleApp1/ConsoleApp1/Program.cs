using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program

    {
        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            //double y;
            //double x = double.Parse(Console.ReadLine());
            //double eps = 0.01;
            //int stepen = 0;
            //int f_kr2 = 1;
            //for (int i = 0; Math.Pow(x,stepen)/f_kr2 > eps; i++)
            //{

            //}

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y <=1 && y>=0 && Math.Abs(x) <= 1)
            {

            }
            else if ()
            {

            }









        }   
    }
}

        //static double sin(double a)
        //{
        //    return Math.Sin(a);    
        //}
            //double a = double.Parse(Console.ReadLine());
            //double eps = 0.001;
            //int b = 0;

            //for (int i = 1; a > eps; i++)
            //{
            //    a = sin(a);
            //    b = i;         
            //}
            //Console.WriteLine(a);   
            //Console.WriteLine(b);