using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class YellowLight : LightState
    {
        public override void ChangeLight()
        {
        
            Console.WriteLine("Wait for green light.");

            Tick();
            Console.WriteLine("Light changed.");
     

        }
    }
}
