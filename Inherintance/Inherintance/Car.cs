using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherintance
{
    internal class Car : Transport
    {
        private const string Information = "максимальная скорость : {0}  |  текущая скорость : {1} |  направление : {2}  |  точка отправки : {3}";

        public string ToCity { get; set; }
        public string FromCity { get; set; }

        public Car(double defSpeed, double maxSpeed, string ToCity, string FromCity) : base(defSpeed, maxSpeed)
        {
            this.ToCity = ToCity;
            this.FromCity = FromCity;
        }
        public override void SpeedDown()
        {
            defSpeed -= 10;
        }
        public override void SpeedUp()
        {
            defSpeed += 20;
        }
        public override string ToString()
        {
            return string.Format(Information, maxSpeed, defSpeed, ToCity, FromCity);
        }
    }
}
