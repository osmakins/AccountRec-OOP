using System;

namespace AccountRecord
{
    class CheckingAccount : AccountBase
    {
        // Fields
        private string accountType = "Checking Account";
        
        // Derived Constructor
        public CheckingAccount(string name, double bal) : base(name, bal) { }

        public override string getAccountType()
        {
            return accountType;
        }

        // Print Method
        public override void printDetails()
        {
            Console.WriteLine("{0}: #{1}", accountType, accountNum);
            base.printDetails();
            Console.WriteLine("");
        }
    }
}
