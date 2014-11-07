using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DukeBennetFS.DAL;
using DukeBennetFS.DAL.Models;

namespace DukeBennetFS
{
    public class FunctionsController : IController
    {
        public void Process(string command, IEnumerable<String> args)
        {
            using (BankInformationDB context = new BankInformationDB())
            {
                // deposit 


                Console.WriteLine("what account would you like to deposit too");
                string accountno = Console.ReadLine();
                Console.WriteLine("How much would you like to deposit");
                string value = Console.ReadLine();
                var accounts = context.Accounts.Where(a => a.AccountNumber == accountno);
                //not quite complete

                //withdrawl
                Account account = context.Accounts.SingleOrDefault(a => a.AccountNumber == accountno);


                if (account != null)
                {
                    account.Balance = (account.Balance + decimal.Parse(value));
                    context.SaveChanges();
                }
            }
        }
    }
}
