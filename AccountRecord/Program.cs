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

            //Create new savings account instances
            SavingsAccount savings1 = new SavingsAccount("Joe", 200);
            SavingsAccount savings2 = new SavingsAccount("John", 500);

            //Call methods on instances
            savings1.printDetails();
            savings2.printDetails();

            savings1.deposit(5000);
            savings1.withdraw(200);
            savings1.earnInterest();

            Console.WriteLine("CHECKING ACCOUNT \n");

            //Create new checking account instances
            CheckingAccount checking1 = new CheckingAccount("Dan", 0);
            CheckingAccount checking2 = new CheckingAccount("Dan", 50000);

            //Call methods on instance
            checking1.printDetails();
            checking1.deposit(-5000);
            checking1.deposit(5000);
            checking1.withdraw(-10000);
            checking1.withdraw(10000);
            checking1.withdraw(100);
            Console.ReadKey();
        }
    }
}
