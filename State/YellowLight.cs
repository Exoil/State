using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class YellowLight : LightState
    {
        public override void ChangeLight(TrafficLight trafficLight)
        {
        
            Console.WriteLine("Wait for green light.");
            Tick();
            trafficLight.SetState(new GreenLight());
            Console.WriteLine("Light changed.");
     

        }
    }
}
