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
            //Create new instance
            SavingsAccount savings1 = new SavingsAccount();

            //Call methods on instance
            savings1.printDetails();
            savings1.deposit(5000);
            savings1.withdraw(100);
            savings1.earnInterest();
            savings1.earnInterest();
        }
    }
}
