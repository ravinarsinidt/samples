using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class ReadMultiple
    {
        public static void Select()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false;MultipleActiveResultSets=False");
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.GetData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id : " + reader["Ids"]);
                        Console.WriteLine("Name : " + reader["Name"]);
                        //Console.WriteLine("Dummy Id : " + rdr[2]);
                    }

                    reader.NextResult();
                }

            }
            catch (Exception ex) { }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
