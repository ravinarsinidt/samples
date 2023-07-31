using System;
using System.Collections.Generic;

#nullable disable

namespace BankingEx.EFModels
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string PanNumber { get; set; }
        public string City { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
