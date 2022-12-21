using WorkNumberSix;

namespace ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            var c = Seconder.SetIntervalTimeFromTicks(12.2);
            Console.WriteLine(c);
        }
    }
}