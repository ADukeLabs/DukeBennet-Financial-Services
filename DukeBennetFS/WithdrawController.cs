using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DukeBennetFS.DAL;
using DukeBennetFS.DAL.Models;

namespace DukeBennetFS
{
    class WithdrawController : IController
    {
        public void Process(string command, IEnumerable<String> args)
        {


            using (BankInformationDB context = new BankInformationDB())
            {
                // withdrawal


                Console.WriteLine("what account would you like to withdraw from ");
                string accountno = Console.ReadLine();
                Console.WriteLine("How much would you like to withdraw");
                string value = Console.ReadLine();
                Account account = context.Accounts.SingleOrDefault(a => a.AccountNumber == accountno);


                if (account != null)
                {
                    account.Balance = (account.Balance - decimal.Parse(value));
                    context.SaveChanges();
                }



                //error view stuff here




                //not quite complete
            }
        }
    }
}
