using System;

namespace AccountRecord
{
    public abstract class AccountBase
    {
        // Fields
        protected string accountOwner;
        protected double balance;
        protected int accountNum;
        protected int transactions = 0;
        protected static int nextAccountNum = 0;

        // Constructor
        public AccountBase(string name, double bal)
        {
            accountOwner = name;
            balance = bal;
            setAccountNumber();
            Console.WriteLine("New Account:");
            printDetails();
        }

        // Set account number
        private void setAccountNumber()
        {
            accountNum = nextAccountNum;
            nextAccountNum++;
        }

        // Print Method
        public virtual void printDetails()
        { 
            Console.WriteLine("Account Owner: " + accountOwner);
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine("Transactions: " + transactions);
            Console.WriteLine("");
        }

        // Deposit Method
        public void deposit(double x)
        {
            if (x > 0)
            {
                balance = balance + x;
                Console.WriteLine("Deposit: $" + x);
                transactions++;
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
                transactions++;
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

        public void resetTransactions() {
            transactions = 0;
            Console.WriteLine("Resetting Transactions to 0");
            printDetails();
        }

        //Getter Methods, used to get the values of fields
        public string getAccountOwner()
        {
            return accountOwner;
        }

        public double getBalance()
        {
            return balance;
        }

        public int getAccountNumber()
        {
            return accountNum;
        }

        public int getTransactions()
        {
            return transactions;
        }

        public abstract string getAccountType();
    }
}
