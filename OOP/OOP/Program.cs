using OOP;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConspleApp
{
    class Program
    {
        public static void Main()
        {
            Company p1 = new Company("fdf","Rddfd", 20);
            Person p2 = p1;
            Console.WriteLine(p2);

        }
    }
}