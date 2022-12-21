using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    public class Fraction
    {
        private int numerator;
        private int denumerator;



        public Fraction(int n, int d)
        { 
            Numerator = n;
            denumerator = d;
        }
        public Fraction(int n) : this(n, 1)
        {
            //numerator = n;
            //denumerator = 1;
        }
        public Fraction(): this(0, 1)
        {
            //numerator = 0;
            //denumerator = 1;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        

        public int Denumerator
        {
            get { return denumerator; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("deniminator  must by positive");
                denumerator = value;

            }
        }

        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denumerator}");
        }

        //public override string tostring()
        //{
        //    if (denumerator == 1)
        //        return $"{numerator}";
        //    return $"{numerator} / {denumerator}";
        //}

        public void Sokr()
        {
            
            
        }
        public void Add(Fraction f)
        {
            this.Numerator = this.Numerator * f.denumerator + 
                f.Numerator * this.denumerator;
            this.denumerator = this.denumerator * f.denumerator;
            Sokr();
            
        }
        public void Add(Fraction f1, Fraction f2)
        {
            this.Numerator = f1.Numerator * f2.denumerator +
                f2.Numerator * f1.denumerator;
            this.denumerator = f1.denumerator * f2.denumerator;
            Sokr();

        }



    }
}