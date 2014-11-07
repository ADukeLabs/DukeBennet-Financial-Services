using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DukeBennetFS.DAL;

namespace DukeBennetFS
{
    class BalanceController : IController
    {
      public void Process(string command, IEnumerable<String> args)
        {
            using (BankInformationDB context = new BankInformationDB())
            {
                // balance


                Console.WriteLine("what account would you tha balance of");
                string accountno = Console.ReadLine();                
                var accounts = context.Accounts.Where(a => a.AccountNumber == accountno);
                Console.WriteLine( accounts = context.Accounts.Where(a => a.AccountNumber == accountno) );
                //not quite complete
            }

        }
    }
}
