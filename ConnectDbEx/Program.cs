using System;
using Microsoft.Data.SqlClient;

namespace ConnectDbEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Student", conn);
                SqlDataReader rdr = null;
                conn.Open();
                rdr = cmd.ExecuteReader();
                cmd.CommandTimeout = 0;
                while (rdr.Read())
                {
                    Console.WriteLine("Id : " + rdr[0]);
                    Console.WriteLine("Name : " + rdr[1]);
                    Console.WriteLine("Dummy Id : " + rdr[2]);
                }
                
            }catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
