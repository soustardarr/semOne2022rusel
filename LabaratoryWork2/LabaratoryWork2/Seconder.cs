using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNumberSix
{
    public class Seconder
    {
        private readonly double _seconds;

        public double Ticks
        {
            get { return _seconds * 18.2; }
        }
        public double Seconds
        {
            get { return _seconds; }
        }
        public double Minutes
        {
            get { return _seconds / 60; }
        }
        private Seconder(double seconds)
        {
            _seconds = seconds;
        }
        public static Seconder SetIntervalFromMinutes(double minutes)
        {
            return new Seconder(minutes * 60);
        }
        public static Seconder SetIntervalTimeFromTicks(double ticks)
        {
            return new Seconder(ticks / 18.2);
        }
        static public Seconder operator +(Seconder t1, Seconder t2)
        {

            return new Seconder(t1.Seconds + t2.Seconds);
        }
        static public Seconder operator -(Seconder t1, Seconder t2)
        {
            return new Seconder(t1.Seconds - t2.Seconds);
        }

        public override string ToString()
        {
            return string.Format("{0:00} ticks {1:00} seconds {2:00} minuts ", Ticks, Seconds, Minutes);
        }

    }
}