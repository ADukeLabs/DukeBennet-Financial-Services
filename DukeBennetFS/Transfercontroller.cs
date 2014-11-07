using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DukeBennetFS.DAL;
using DukeBennetFS.DAL.Models;

namespace DukeBennetFS
{
    internal class Transfercontroller : IController
    {
        public void Process(string command, IEnumerable<String> args)
        {
            Console.WriteLine(command);
            // in here will be the calls to the database yada yada yada

            using (BankInformationDB context = new BankInformationDB())
            {



                Console.WriteLine("what account would you like to withdraw from ");
                string accountno = Console.ReadLine();
                Console.WriteLine("What account would you like to deposit too ");
                string transferAccountNumber = Console.ReadLine();
                Console.WriteLine("How much do you want to deposit in this account ");
                string value = Console.ReadLine();
                Account account = context.Accounts.SingleOrDefault(a => a.AccountNumber == accountno);
                Account account1 = context.Accounts.SingleOrDefault(a => a.AccountNumber == transferAccountNumber);

                if (account != null)
                {
                    account.Balance = (account.Balance - decimal.Parse(value));
                    account1.Balance = (account1.Balance + decimal.Parse(value));
                    context.SaveChanges();
                }
            }
        }
    }
}