using DukeBennetFS.DAL.Models;

namespace DukeBennetFS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DukeBennetFS.DAL.BankInformationDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DukeBennetFS.DAL.BankInformationDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            
            context.Accounts.Add(

              new Account { CustomerFullName = Faker.Name.FullName(), AccountNumber = Faker.RandomNumber.Next(1000000, 9999999).ToString(), AccountType = "savings", Balance = Faker.RandomNumber.Next(0, 100000) / 100.0m}

            );
            context.SaveChanges();
            //
        }
    }
}
