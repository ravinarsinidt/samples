using BankingEx.Models;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using BankingEx.EFModels;

namespace BankingEx.PersistanceLayer
{
    public class EmployeeContext
    {
        public static bool Create(Employee employee)
        {
            SqlConnection connection = new SqlConnection("Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = $"INSERT INTO dbo.Employee(name, userName, password) " +
                                        $"VALUES('{employee.Name}', '{employee.UserName}', '{employee.Password}')";

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

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection connection = new SqlConnection($"Server=RAVINARSINI;Database=AudreeBank" +
                $";User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string seelctCommand = "SELECT * FROM dbo.Employee";
                SqlCommand command = new SqlCommand(seelctCommand, connection);
                connection.Open();
                SqlDataReader resultReader = command.ExecuteReader();
                while (resultReader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = int.Parse(resultReader["Id"].ToString());
                    employee.Name = resultReader["Name"].ToString();
                    employee.UserName = resultReader["UserName"].ToString();
                    employee.Password = resultReader["Password"].ToString();

                    employees.Add(employee);
                }
                connection.Close();
                return employees;
                
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
    
        public static Employee Login(string userName, string password) 
        {
            SqlConnection connection = new SqlConnection("Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false");
            Employee employee = null;
            try
            {
                string selectCommand = "SELECT * FROM dbo.Employee WHERE UserName = @p1 AND Password = @p2";

                //string selectCommand = $"SELECT * FROM dbo.Employee" +
                //    $" WHERE UserName = '{userName}' AND Password = '{password}'";

                SqlCommand command = new SqlCommand(selectCommand, connection);
                command.Parameters.Add(new SqlParameter("@p1", userName));
                command.Parameters.Add(new SqlParameter("@p2", password));

                connection.Open();
                SqlDataReader resultReader = command.ExecuteReader();
                
                while (resultReader.Read())
                {
                    employee = new Employee();
                    employee.Id = int.Parse(resultReader["Id"].ToString());
                    employee.Name = resultReader["Name"].ToString();
                    employee.UserName = resultReader["UserName"].ToString();
                    employee.Password = resultReader["Password"].ToString();
                }
                connection.Close();
                return employee;
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

        public static Employee GetEmployeeById(int id)
        {
            SqlConnection connection = new SqlConnection("Server=RAVINARSINI;Database=AudreeBank;User Id=sa;Password=adminadmin;encrypt=false");
            Employee employee = null;
            try
            {
                string selectCommand = $"SELECT * FROM dbo.Employee" +
                    $" WHERE Id = {id}";

                SqlCommand command = new SqlCommand(selectCommand, connection);
                connection.Open();
                SqlDataReader resultReader = command.ExecuteReader();
                while (resultReader.Read())
                {
                    employee = new Employee();
                    employee.Id = int.Parse(resultReader["Id"].ToString());
                    employee.Name = resultReader["Name"].ToString();
                    employee.UserName = resultReader["UserName"].ToString();
                    employee.Password = resultReader["Password"].ToString();
                }
                connection.Close();
                return employee;
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

        internal static List<string> GetUserRolesByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
