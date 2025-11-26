using System;

namespace DotnetWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcc = new BankAccount("ACC12345", 5000);

            Console.WriteLine("Account Number: " + myAcc.AccountNumber);
            Console.WriteLine("Initial Balance: " + myAcc.Balance);

            // Deposit money
            myAcc.Deposit(2000);
            Console.WriteLine("Balance after deposit: " + myAcc.Balance);

            // Withdraw money
            myAcc.Withdraw(1500);
            Console.WriteLine("Balance after withdrawal: " + myAcc.Balance);

            Console.ReadLine();
        }
    }
}
