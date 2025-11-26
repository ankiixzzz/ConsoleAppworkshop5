using System;

namespace DotnetWorkshop
{
    public class Laptop : ElectronicDevice
    {
        public int RAM { get; set; } // Optional extra property

        public Laptop(string brand, double price, int ram = 8) : base(brand, price)
        {
            RAM = ram;
        }

        // Child-specific method
        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} laptop battery is now ON.");
        }

        // Override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}, RAM: {RAM}GB");
        }
    }
}
