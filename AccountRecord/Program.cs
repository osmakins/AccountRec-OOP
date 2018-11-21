using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AccountRecord
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<AccountBase> accountList = new List<AccountBase>();
            accountList.Add(new SavingsAccount("Duke", 100));
            accountList.Add(new SavingsAccount("Hans", 20000));
            accountList.Add(new SavingsAccount("David", 50000));
            accountList.Add(new SavingsAccount("Hope", 500));
            accountList.Add(new CheckingAccount("Grit", 0));
            accountList.Add(new CheckingAccount("Josh", 500));

            Application.Run(new AccountRecords(accountList));
            Console.ReadKey();
        }

        
    }
}
