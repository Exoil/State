using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class RedLight : LightState
    {
        public override  void ChangeLight()
        {
  
            Console.WriteLine("Wait for yellow light");
            Tick();
            Console.WriteLine("light changed");

        }


    }
}
