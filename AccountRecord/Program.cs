using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAVINGS ACCOUNT \n");

            //Create new savings account instance
            SavingsAccount savings1 = new SavingsAccount();

            //Call methods on instance
            savings1.printDetails();
            savings1.deposit(5000);
            savings1.withdraw(100);
            savings1.earnInterest();
            savings1.earnInterest();

            Console.WriteLine("CHECKING ACCOUNT \n");

            //Create new checking account instance
            CheckingAccount checking1 = new CheckingAccount();

            //Call methods on instance
            checking1.printDetails();
            checking1.deposit(-5000);
            checking1.deposit(5000);
            checking1.withdraw(-10000);
            checking1.withdraw(10000);
            checking1.withdraw(100);
        }
    }
}
