using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class SelectEx
    {
        public static void Select()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Student", conn);
                SqlDataReader rdr = null;
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("Id : " + rdr[0]);
                    Console.WriteLine("Name : " + rdr[1]);
                    Console.WriteLine("Dummy Id : " + rdr[2]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
