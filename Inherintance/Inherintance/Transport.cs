using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherintance
{
    abstract class Transport
    {
        protected double defSpeed;
        protected double maxSpeed;

        public Transport(double defSpeed, double maxSpeed)
        {
            this.defSpeed = defSpeed;
            this.maxSpeed = maxSpeed;
        }
        public abstract void SpeedUp();


        public abstract void SpeedDown();
        
    }
}
