using System;
using System.Collections.Generic;

namespace DotnetWorkshop
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Add device
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        // Remove device
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Contains(device))
            {
                devices.Remove(device);
                Console.WriteLine($"{device.Brand} removed from the store.");
            }
        }

        // Show info for all devices
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n=== Store Device Details ===");
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcast to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine(); // Separator
            }
        }
    }
}
