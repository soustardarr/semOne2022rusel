using Inherintance;

namespace InherIntance
{
    class Program
    {
        public static void Main()
        {

            List<Transport> ts = new List<Transport>()
            {
                new Car(50, 200, "Kazan", "Moscow"),
                new Airplane(300, 700, "Kazan", "Krasnodar"),
                new Ship(25, 130, "Kazan", "Yoshkar-Ola")
            };

            foreach(var item in ts)
            {
                item.SpeedUp();
                item.SpeedUp();
                item.SpeedDown();
                Console.WriteLine(item);
            }





        }
    }
}