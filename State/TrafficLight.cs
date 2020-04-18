using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TrafficLight
    {
        private LightState currentState;
        

        public void SetState(LightState light)
        {
            
            currentState = light;
        }

        public void TrunLight()
        {
            currentState.ChangeLight();
       

        }
    }
}
