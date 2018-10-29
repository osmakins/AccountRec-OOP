using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRecord
{
    class SavingsAccount
    {
        // Fields
        private string accountType = "Savings Account";
        private string accountOwner;
        private double balance;
        private static double interestRate = 0.02;
        private int accountNum;
        private static int nextAccountNum = 0;

        // Constructor
        public SavingsAccount(string name, double bal)
        {
            accountOwner = name;
            balance = bal;
            setAccountNumber();
        }

        // Set account number
        private void setAccountNumber()
        {
            accountNum = nextAccountNum;
            nextAccountNum++;
        }

        // Print Method
        public void printDetails()
        {
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Account Owner: " + accountOwner);
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine("Interest Rate: " + interestRate);
            Console.WriteLine("");
        }

        public void earnInterest()
        {
            Console.WriteLine("Interest: $" + balance * (interestRate / 12));
            balance = balance * (1 + interestRate / 12);
            printDetails();
        }
        
        // Depositing method
        public void deposit(double x)
        {
            if (x > 0)
            {
                balance = balance + x;
                Console.WriteLine("Deposit: $" + x);
                printDetails();
            }
            else
            {
                Console.WriteLine("Cannot deposit negative amount: " + x);
                Console.WriteLine("");
            }
        }

        // Withdrawal method
        public void withdraw(double x)
        {
            if (x > 0 && (balance - x > 0))
            {
                balance = balance - x;
                Console.WriteLine("Withdraw: $" + x);
                printDetails();
            }
            else if (x < 0)
            {
                Console.WriteLine("Cannot withdraw negative amount: " + x);
                Console.WriteLine("");
            }
            else if (balance - x < 0)
            {
                Console.WriteLine("Cannot withdraw $" + x + " from $" + balance + " account");
                Console.WriteLine("Balance cannot go negative.");
                Console.WriteLine("");
            }
        }
    }
}
