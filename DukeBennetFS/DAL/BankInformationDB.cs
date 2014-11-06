using DukeBennetFS.DAL.Models;

namespace DukeBennetFS.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankInformationDB : DbContext
    {
        public BankInformationDB()
            : base("name=BankInformationDB")
        {
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
