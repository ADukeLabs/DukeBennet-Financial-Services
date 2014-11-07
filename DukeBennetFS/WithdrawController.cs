using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DukeBennetFS.DAL;

namespace DukeBennetFS
{
    class WithdrawController
    {
        public void Process(string command, IEnumerable<String> args)
        {


            using (BankInformationDB context = new BankInformationDB())
            {
                // withdrawal


                Console.WriteLine("what account would you like to withdraw from ");
                string accountno = Console.ReadLine();
                Console.WriteLine("How much would you like to withdraw");
                string deposit = Console.ReadLine();
                var accounts = context.Accounts.Where(a => a.AccountNumber == accountno);
                //not quite complete
            }
        }
    }
}
