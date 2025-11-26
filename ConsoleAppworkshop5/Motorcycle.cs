using System;

namespace DotnetWorkshop
{
    // Only one Motorcycle class for abstract Vehicle
    public class Motorcycle : Vehicle
    {
        // Implement abstract methods
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Motorcycle engine stopped.");
        }
    }
}
