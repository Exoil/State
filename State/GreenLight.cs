using System;
using System.Threading.Tasks;

namespace State
{
    public class GreenLight : LightState
    {
        public override async void ChangeLight(TrafficLight trafficLight)
        {
      
            Console.WriteLine("Wait for red light");
            Tick();
            trafficLight.SetState(new RedLight());
            Console.WriteLine("Change to red light");
          

        }
    }
}
