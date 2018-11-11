using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRecord
{
    public partial class AccountRecords : Form
    {
        private List<AccountBase> accountListing = new List<AccountBase>();
       
        public AccountRecords(List<AccountBase> L)
        {
            accountListing = L;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                            listChecker = selectAcct;
                    }
                }
                if(listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else
                {
                    listChecker.printDetails();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                        listChecker = selectAcct;
                    }
                }
                if (listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else
                {
                    listChecker.deposit(200);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                        listChecker = selectAcct;
                    }
                }
                if (listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else
                {
                    listChecker.withdraw(200);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                        listChecker = selectAcct;
                    }
                }
                if (listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else
                {
                    Console.WriteLine("CLOSING...\n");
                    accountListing.Remove(listChecker);
                    Console.WriteLine("{0} has been removed.\n", listChecker.getAccountOwner());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                        listChecker = selectAcct;
                    }
                }
                if (listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else if(listChecker.getAccountType() == "Savings Account" && listChecker.getBalance() >= 20000)
                {
                    listChecker.deposit(20);
                    Console.WriteLine("Bonus for high savings account\n");
                }
                else
                {
                    Console.WriteLine("You do not have any bonus\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AccountBase listChecker = null;
            try
            {
                foreach (AccountBase selectAcct in accountListing)
                {
                    if (selectAcct.getAccountOwner() == AcctName.Text && selectAcct.getAccountNumber() == Convert.ToInt32(AcctNum.Text))
                    {
                        listChecker = selectAcct;
                    }
                }
                if (listChecker == null)
                {
                    Console.WriteLine("Please check that you have entered the correct account name and number.\n");
                }
                else if (listChecker.getAccountType() == "Savings Account")
                {
                    var pointer = accountListing.IndexOf(listChecker);
                    SavingsAccount a = (SavingsAccount) accountListing[pointer];
                    a.earnInterest();
                }
                else
                {
                    Console.WriteLine("You have no interest at the moment.\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Account number can only be integer numbers!\n");
            }
        }
    }
}
