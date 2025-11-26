//using System;

//namespace DotnetWorkshop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount myAcc = new BankAccount("ACC12345", 5000);

//            Console.WriteLine("Account Number: " + myAcc.AccountNumber);
//            Console.WriteLine("Initial Balance: " + myAcc.Balance);

//            // Deposit money
//            myAcc.Deposit(2000);
//            Console.WriteLine("Balance after deposit: " + myAcc.Balance);

//            // Withdraw money
//            myAcc.Withdraw(1500);
//            Console.WriteLine("Balance after withdrawal: " + myAcc.Balance);

//            Console.ReadLine();
//        }
//    }
//}
//namespace DotnetWorkshop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create Car object
//            Car car = new Car("Toyota", 180, 5);

//            Console.WriteLine("=== Car Info ===");
//            car.Start();
//            car.DisplayInfo();
//            car.Stop();

//            Console.WriteLine();

//            // Create Motorcycle object
//            Motorcycle bike = new Motorcycle("Yamaha", 150, true);

//            Console.WriteLine("=== Motorcycle Info ===");
//            bike.Start();
//            bike.DisplayInfo();
//            bike.Stop();

//            Console.ReadLine();
//        }
//    }
//}
using System;

//namespace DotnetWorkshop

//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Printer printer = new Printer();

//            // Call overload 1
//            printer.Print("Hello, Ankita!");

//            // Call overload 2
//            printer.Print(123);

//            // Call overload 3
//            printer.Print("Repeated message", 3);

//            Console.ReadLine();
//        }
//    }
//}
//using System;

//using System;

//namespace DotnetWorkshop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Car object
//            Car car = new Car();
//            Console.WriteLine("=== Car ===");
//            car.Display();
//            car.StartEngine();
//            car.StopEngine();

//            Console.WriteLine();

//            // Motorcycle object
//            Motorcycle bike = new Motorcycle();
//            Console.WriteLine("=== Motorcycle ===");
//            bike.Display();
//            bike.StartEngine();
//            bike.StopEngine();

//            Console.ReadLine();
//        }
//    }
//}
using System;

namespace DotnetWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create store
            ElectronicsStore store = new ElectronicsStore();

            // Create devices
            Laptop laptop1 = new Laptop("Dell", 1200, 16);
            Smartphone phone1 = new Smartphone("Samsung", 800, "Android");

            // Add devices to store
            store.AddDevice(laptop1);
            store.AddDevice(phone1);

            // Show all devices
            store.ShowAllDeviceDetails();

            Console.ReadLine();
        }
    }
}

