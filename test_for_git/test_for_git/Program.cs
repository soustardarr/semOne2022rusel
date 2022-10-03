
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.ExceptionServices;
//static bool isprost(int number)
//{
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//            return false;
//    }
//    return true;
//}

//List<int> deliteli = new List<int>();
//int n = 37;
//int b = Convert.ToInt32(Math.Pow(n, 0.5));
//for (int i = 2; i < b; i++)
//{
//    if (b % i == 0)
//    {
//        if (isprost(i))
//        {
//            deliteli.Add(i);
//        }
//        if (isprost(b / i))
//        {
//            int c = b / i;
//            deliteli.Add(c);
//        }
//    }

//}
//foreach (var item in deliteli)
//{
//    Console.WriteLine(item);
//}
//double x = double.Parse(Console.ReadLine());
//double y = double.Parse(Console.ReadLine());
//if ((y <= 1 && y >= 0 && Math.Abs(x) <= 1) && (Math.Abs(x) + Math.Abs(y) <= 1))
//{
//    Console.WriteLine("принадлежит");
//}
//else if (Math.Abs(x) <= 1 && ((y >= -1 * x * x) && (y < 0)))
//{
//    Console.WriteLine("принадлежит");

//}
//else
//{
//    Console.WriteLine("не принадлежит");
//}


//NOD and NOK
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int nod = -10000000;
//int i = 100000;
//while (i != 0)
//{
//    if ((a % i == 0) && (b % i == 0))
//    {
//        if (i > nod)
//        {
//            nod = i;
//        }
//    }
//    i--;
//}

//Console.WriteLine(nod);

//int NOK(int n1, int n2)
//{
//    return n1 * n2 / nod;
//}

//Console.WriteLine(NOK(a,b));


//static bool isprost(int a)
//{
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i != 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}


class Programm
{
    static double Hn(double n)
    {
        double sum = 0;
        for (double k = 1.0; k <= n; k++)
        {
            double b = 1.0 / k;
            if (b <= 0.0001)
            {
                break;
            }
            sum += b;
        }
        return sum;
    }
    public static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double l = Math.Log(n, Math.E);
        double s = (Math.Pow(n, 4.0));
        double y = (Hn(n)) - l - (1.0 / (2 * n)) + (1.0 / (12 * (n * n))) - (1.0 / (120 * s));
        Console.WriteLine(y);


    }
}