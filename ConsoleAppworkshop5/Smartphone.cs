using System;

namespace DotnetWorkshop
{
    public class Smartphone : ElectronicDevice
    {
        public string OperatingSystem { get; set; }

        public Smartphone(string brand, double price, string os = "Android") : base(brand, price)
        {
            OperatingSystem = os;
        }

        // Child-specific method
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera is now enabled.");
        }

        // Override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}, OS: {OperatingSystem}");
        }
    }
}
