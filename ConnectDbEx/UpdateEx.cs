using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class UpdateEx
    {
        public static void Update()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = "UPDATE Student SET Name = 'Chnaged Name' WHERE Id = 3";
                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Number of rows Updated : " + result);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if(conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
