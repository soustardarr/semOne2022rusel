using WorkNumberSix;

namespace LabaratoryWork
{
    class Program
    {
        public static void Main()
        {
            var c = Ticker.SetIntervalFromSeconds(23.2);
            Console.Write(c);
        }
    }
}