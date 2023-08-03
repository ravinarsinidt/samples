using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using BankingEx.EFModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BankingEx.EFPersistanceLayer
{
    public class EFCustomerContext
    {
        public static bool Create(Customer customer)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);

                db.Customers.Add(customer);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<Customer> GetCustomers()
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);

                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                List <Customer> customers = db.Customers.ToList();
                return customers;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Customer GetCustomerById(int id)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                Customer customer = db.Customers.Find(id);
                return customer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static bool UpdateCustomer(Customer customer)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                db.Customers.Update(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static bool Delete(int id)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);

                Customer customer = db.Customers.Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}