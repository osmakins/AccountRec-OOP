using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRecord
{
    class SavingsAccount : AccountBase
    {
        // Fields
        private string accountType = "Savings Account";
        private static double interestRate = 0.02;
      
        // Constructor
        public SavingsAccount(string name, double bal) : base(name, bal){ }

        // Print Method
        new public void printDetails()
        {
            Console.WriteLine(accountType + " #" + accountNum);
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
