using AudreeBankApi.PersistanceLayer.EFDataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AudreeBankApi.PersistanceLayer
{
    public class CustomerPersistance : ICustomerPersistance
    {
        public bool Create(Customer customer)
        {
            string connection = "Server=RAVINARSINI;Database=NewBank;User Id=sa;Password=adminadmin;encrypt=false";
            try
            {
                DbContextOptionsBuilder<AudreeBankData> dbContextOptionsBuilder = new DbContextOptionsBuilder<AudreeBankData>();
                dbContextOptionsBuilder.UseSqlServer(connection);
                AudreeBankData database = new AudreeBankData(dbContextOptionsBuilder.Options);
                database.Customers.Add(customer);
                database.SaveChanges();
                return true;
            }
            catch 
            { 
                return false;
            }
        }

        public List<Customer> Get()
        {
            string connection = "Server=RAVINARSINI;Database=NewBank;User Id=sa;Password=adminadmin;encrypt=false";
            try
            {
                DbContextOptionsBuilder<AudreeBankData> dbContextOptionsBuilder = new DbContextOptionsBuilder<AudreeBankData>();
                dbContextOptionsBuilder.UseSqlServer(connection);
                AudreeBankData database = new AudreeBankData(dbContextOptionsBuilder.Options);
                List<Customer> result = database.Customers.ToList();
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
