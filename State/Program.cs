using System;
using System.Diagnostics;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State example");

            var trafficLight = new TrafficLight();
            trafficLight.SetState(new RedLight());
            trafficLight.TrunLight();
            trafficLight.SetState(new YellowLight());
            trafficLight.TrunLight();
            trafficLight.SetState(new GreenLight());
            trafficLight.TrunLight();
            trafficLight.SetState(new RedLight());

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
