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
namespace DotnetWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car car = new Car("Toyota", 180, 5);

            Console.WriteLine("=== Car Info ===");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            // Create Motorcycle object
            Motorcycle bike = new Motorcycle("Yamaha", 150, true);

            Console.WriteLine("=== Motorcycle Info ===");
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();

            Console.ReadLine();
        }
    }
}
