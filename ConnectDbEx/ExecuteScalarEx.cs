using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class ExecuteScalarEx
    {
        public static void GetTotalRecordsCount()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = "SELECT AVG(DummyId) FROM Student";
                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                int value = int.Parse(result.ToString());
                Console.WriteLine("Number of rows : " + result.ToString());

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
