﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRecord
{
    class CheckingAccount
    {
        // Fields
        private string accountType = "Checking Account";
        private string accountOwner = "Dan";
        private double balance = 0.0;
        private int accountNum;
        private static int nextAccountNum = 0;

        // Constructor
        public CheckingAccount(string name, double bal) {
            accountOwner = name;
            balance = bal;
            setAccountNum();
        }

        // Set account number
        private void setAccountNum()
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
            Console.WriteLine("");
        }

        // Deposit Method
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
