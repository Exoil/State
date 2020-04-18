using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class RedLight : LightState
    {
        public override  void ChangeLight(TrafficLight trafficLight)
        {
  
            Console.WriteLine("Wait for yellow light");
            Tick();
            trafficLight.SetState(new YellowLight());
            Console.WriteLine("light changed");

        }


    }
}
