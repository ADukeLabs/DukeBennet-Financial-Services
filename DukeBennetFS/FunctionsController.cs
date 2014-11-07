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



                Console.WriteLine("what account would you like to deposit too");
                string accountno = Console.ReadLine();
                Console.WriteLine("How much would you like to deposit");
                string deposit = Console.ReadLine();
                var accounts = context.Accounts.Where(a => a.AccountNumber == accountno);
            }
        }
    }
}
