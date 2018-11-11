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
    }
}
