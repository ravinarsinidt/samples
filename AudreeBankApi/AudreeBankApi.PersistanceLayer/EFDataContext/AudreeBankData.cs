using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AudreeBankApi.PersistanceLayer.EFDataContext
{
    public class AudreeBankData : DbContext
    {
        public AudreeBankData(DbContextOptions<AudreeBankData> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.plConventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
