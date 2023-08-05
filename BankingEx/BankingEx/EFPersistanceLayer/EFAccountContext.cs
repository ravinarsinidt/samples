using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using BankingEx.EFModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Metadata;

namespace BankingEx.EFPersistanceLayer
{
    public class EFAccountContext
    {
        public static bool Create(Account account)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);

                db.Accounts.Add(account);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<Account> GetAccounts()
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);

                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                List <Account> accounts = db.Accounts.ToList();
                return accounts;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Account GetAccountById(int id)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                Account account = db.Accounts.Find(id);
                db.Entry(account).Reference(b => b.Customer).Load();
                return account;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static bool UpdateAccount(Account account)
        {
            string connectionString = "Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false";

            try
            {
                DbContextOptionsBuilder<AudreeBankContext> optionsBuilder = new DbContextOptionsBuilder<AudreeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                AudreeBankContext db = new AudreeBankContext(optionsBuilder.Options);
                db.Accounts.Update(account);
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

                Account account = db.Accounts.Find(id);
                if(account != null)
                {
                    db.Accounts.Remove(account);
                    db.SaveChanges();
                }
                
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}