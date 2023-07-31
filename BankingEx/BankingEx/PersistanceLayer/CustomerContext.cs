using BankingEx.Models;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace BankingEx.PersistanceLayer
{
    public class CustomerContext
    {
        public static bool Create(Customer customer)
        {
            SqlConnection connection = new SqlConnection("Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string dbDateFormat = customer.DoB.ToString("yyyy-MM-dd");
                string insertCommand = $"INSERT INTO dbo.Customer(name, Dobs, PanNumber, City) " +
                                        $"VALUES('{customer.Name}', '{dbDateFormat}', '{customer.PAN}'" +
                                        $", '{customer.City}')";
                SqlCommand command = new SqlCommand(insertCommand, connection);
                connection.Open();
                int resultCount = command.ExecuteNonQuery();
                connection.Close();
                if (resultCount > 0)
                {
                    return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open) 
                {
                    connection.Close();
                }
            }
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection connection = new SqlConnection($"Server=RAVINARSINI;Database=AudreeBank" +
                $";User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string seelctCommand = "SELECT * FROM dbo.Customer";
                SqlCommand command = new SqlCommand(seelctCommand, connection);
                connection.Open();
                SqlDataReader resultReader = command.ExecuteReader();
                while (resultReader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = int.Parse(resultReader["Id"].ToString());
                    customer.Name = resultReader["Name"].ToString();
                    customer.DoB = DateTime.Parse(resultReader["Dob"].ToString());
                    customer.PAN = resultReader["PanNumber"].ToString();
                    customer.City = resultReader["City"].ToString();

                    customers.Add(customer);
                }
                connection.Close();
                return customers;
                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
