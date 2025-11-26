//namespace DotnetWorkshop
//{
//    public class Car : Vehicle
//    {
//        public int Seats { get; set; }

//        public Car(string brand, int speed, int seats) : base(brand, speed)
//        {
//            Seats = seats;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Seats: {Seats}");
//        }
//    }
//}
using System;

namespace DotnetWorkshop
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}
