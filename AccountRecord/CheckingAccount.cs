using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRecord
{
    class CheckingAccount : AccountBase
    {
        // Fields
        private string accountType = "Checking Account";
        
        // Constructor
        public CheckingAccount(string name, double bal) : base(name, bal) { }

        // Print Method
        new public void printDetails()
        {
            Console.WriteLine(accountType + " #" + accountNum);
            base.printDetails();
            Console.WriteLine("");
        }
    }
}
