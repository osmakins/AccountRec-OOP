using System;

namespace AccountRecord
{
    class SavingsAccount : AccountBase
    {
        // Fields
        private string accountType = "Savings Account";
        private static double interestRate = 0.05;
      
        // Derived Constructor
        public SavingsAccount(string name, double bal) : base(name, bal){ }

        public override string getAccountType()
        {
            return accountType;
        }

        // Print Method
        override public void printDetails()
        {
            Console.WriteLine("{0}: #{1}", accountType, accountNum);
            base.printDetails();
            Console.WriteLine("");
        }

        public void earnInterest()
        {
            Console.WriteLine("Interest: $" + balance * (interestRate / 12));
            balance = balance * (1 + interestRate / 12);
            printDetails();
        }
    }
}
