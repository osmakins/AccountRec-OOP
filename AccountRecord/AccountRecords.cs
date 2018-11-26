using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace AccountRecord
{
    public partial class AccountRecords : Form
    {
        public List<AccountBase> accountListing = new List<AccountBase>();

        public AccountRecords(List<AccountBase> L)
        {
            accountListing = L;
            InitializeComponent();
        }

        private static string emptySelection()
        {
            return "Please check that you have entered the correct account name and number.\n";
        }

        private string accountTypeError()
        {
            string accountType = selectedAccount().getAccountType();
            string accountOwner = selectedAccount().getAccountOwner();
            return accountOwner + " has " + accountType;
        }

        // Select an Account from the list
        private AccountBase selectedAccount()
        {
            AccountBase selectAccount = null;
            try
            {
                // Lambda expression.
                selectAccount = accountListing.Find(A => A.getAccountOwner() == AcctName.Text && A.getAccountNumber() == Convert.ToInt32(AcctNum.Text));
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
            return selectAccount;        
        }

        // Print Details
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount().printDetails();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(emptySelection());
            }
        }

        //Deposit fund
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount().deposit(200);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(emptySelection());
            }
        }

        // Withdraw fund
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount().withdraw(200);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(emptySelection());
            }
        }

        // Close Account
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("CLOSING...\n" + selectedAccount().getAccountOwner() + " has been removed.\n");
                accountListing.Remove(selectedAccount());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(emptySelection());
            }
        }

        // Give Bonus
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SavingsAccount savingsAccount = (SavingsAccount)selectedAccount();
                if(savingsAccount.getBalance() >= 20000)
                {
                    savingsAccount.deposit(25);
                    Console.WriteLine("Bonus for high balance record.\n");
                }
                else
                {
                    Console.WriteLine("No bonuses at the moment.\n");
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    Console.WriteLine(accountTypeError());
                else if (ex is NullReferenceException)
                    Console.WriteLine(emptySelection());
                else
                    Console.WriteLine("Unknown error");
            }
        }

        // Earn Interest
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SavingsAccount savingsAccount = (SavingsAccount)selectedAccount();
                savingsAccount.earnInterest();
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    Console.WriteLine(accountTypeError());
                else if (ex is NullReferenceException)
                    Console.WriteLine(emptySelection());
                else
                    Console.WriteLine("Unknown error");
            }
        }

        // Charge Fee
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                CheckingAccount checkingAccount = (CheckingAccount)selectedAccount();
                if (checkingAccount.getTransactions() <= 0)
                {
                    checkingAccount.withdraw(35);
                    Console.WriteLine("Fee for not having enough transaction.\n");
                }
                else
                {
                    Console.WriteLine("No fees charged at the moment.\n");
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    Console.WriteLine(accountTypeError());
                else if (ex is NullReferenceException)
                    Console.WriteLine(emptySelection());
                else
                    Console.WriteLine("Unknown error");
            }
        }

        // Reset Transaction
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount().resetTransactions();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(emptySelection());
            }
        }
    }
}