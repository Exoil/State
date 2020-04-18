using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State
{
    public abstract class LightState
    {
        public abstract void ChangeLight(TrafficLight trafficLight);


        public bool Tick()
        {
            Thread.Sleep(1000);
            return true;
        }
       
    }
}
