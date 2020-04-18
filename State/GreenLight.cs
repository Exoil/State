using System;
using System.Threading.Tasks;

namespace State
{
    public class GreenLight : LightState
    {
        public override async void ChangeLight()
        {
      
            Console.WriteLine("Wait for red light");
            Tick();        
            Console.WriteLine("Change to red light");
          

        }
    }
}
