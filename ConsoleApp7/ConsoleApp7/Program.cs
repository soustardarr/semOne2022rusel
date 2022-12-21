using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Today;
            var i = dt.Year + dt2.Year;
            Console.WriteLine(i);
        }
    }
}
