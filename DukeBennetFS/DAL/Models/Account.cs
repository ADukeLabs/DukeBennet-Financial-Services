using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukeBennetFS.DAL.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string CustomerFullName { get; set; }
        public decimal Balance { get; set; }

    }
}
