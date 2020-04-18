using System;
using System.Diagnostics;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State example, starts from red light");

            var trafficLight = new TrafficLight();
            trafficLight.SetState(new RedLight());
            trafficLight.TrunLight();
            trafficLight.TrunLight();
            trafficLight.TrunLight();

            Console.WriteLine("End, you can go");
            Console.ReadLine();
        }
    }
}
