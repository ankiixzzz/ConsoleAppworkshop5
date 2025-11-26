//namespace DotnetWorkshop
//{
//    public class BankAccount
//    {
//        // Private fields
//        private string accountNumber;
//        private double balance;

//        // Public property - AccountNumber (Only Get)
//        public string AccountNumber
//        {
//            get { return accountNumber; }
//        }

//        // Public property - Balance (Get only, private set)
//        public double Balance
//        {
//            get { return balance; }
//            private set
//            {
//                if (value > 0)
//                {
//                    balance = value;
//                }
//                else
//                {
//                    Console.WriteLine("Balance cannot be zero or negative.");
//                }
//            }
//        }

//        // Constructor to set account number and initial balance
//        public BankAccount(string accNo, double initialBalance)
//        {
//            accountNumber = accNo;
//            Balance = initialBalance;  // uses the property setter
//        }

//        // Deposit Method
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine($"Deposited: {amount}");
//            }
//            else
//            {
//                Console.WriteLine("Deposit amount must be greater than 0");
//            }
//        }

//        // Withdraw Method
//        public void Withdraw(double amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine("Withdraw amount must be greater than 0");
//            }
//            else if (amount > balance)
//            {
//                Console.WriteLine("Insufficient balance!");
//            }
//            else
//            {
//                balance -= amount;
//                Console.WriteLine($"Withdrawn: {amount}");
//            }
//        }
//    }
//}


