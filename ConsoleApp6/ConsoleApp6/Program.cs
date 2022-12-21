
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1  = new ComplexNumber(13,20);
            ComplexNumber c2 = new ComplexNumber(2,3);
            c2.AbcZ = Math.Sqrt(c2.Re * c2.Re + c2.Im * c2.Im);
            c2.Arg = Math.Atan(c2.Im / c2.Re) * 180 / Math.PI;
            Console.WriteLine(c1/c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 + c2);







        }
    }
}

