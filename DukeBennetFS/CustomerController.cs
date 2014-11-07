using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DukeBennetFS.DAL;
using DukeBennetFS.DAL.Models;

namespace DukeBennetFS
{
    public class CustomerController : IController
    {
        public void Process(string command, IEnumerable<String> args)
        {
            using (BankInformationDB context = new BankInformationDB())
            {
                Console.WriteLine("Please Choose your account type: Checking or Savings");
                string accountType = Console.ReadLine();
                Console.WriteLine("Please enter your full name");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your current account balance");
                string accountBalance = Console.ReadLine();
                Account account = new Account()
                {
                    AccountNumber = Faker.RandomNumber.Next(1000000, 9999999).ToString(),
                    AccountType = accountType,
                    CustomerFullName = name,
                    Balance = decimal.Parse(accountBalance)

                };
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }
    }
}
