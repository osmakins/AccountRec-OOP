using System;

namespace AccountRecord
{
    class CheckingAccount : AccountBase
    {
        // Fields
        private string accountType = "Checking Account";
        
        // Derived Constructor
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
