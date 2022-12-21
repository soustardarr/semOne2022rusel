using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNumberSix
{
    public class Ticker
    {
        private readonly double ticks;
        private Ticker(double tik)
        {
            ticks = tik;
        }

        public double Ticks
        {
            get { return ticks; }
        }
        public double Seconds
        {
            get { return ticks / 18.2; }
        }
        public double Minuts
        {
            get { return ticks / 18.2 / 60; }
        }
        public static Ticker SetIntervalFromSeconds(double seconds)
        {
            return new Ticker(seconds * 18.2);
        }
        public static Ticker SetIntervalFromTicks(double tik)
        {
            return new Ticker(tik);
        }
        static public Ticker operator +(Ticker t1, Ticker t2)
        {

            return new Ticker(t1.Ticks + t2.Ticks);
        }
        static public Ticker operator -(Ticker t1, Ticker t2)
        {
            return new Ticker(t1.Ticks - t2.Ticks);
        }
        public override string ToString()
        {
            return string.Format("{0:00} ticks {1:00} seconds {2:00} minuts", Ticks, Seconds, Minuts);
        }
    }
}