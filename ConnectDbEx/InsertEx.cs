using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class InsertEx
    {
        public static void Insert(string name, int dummyId)
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = $"INSERT INTO Student(Name, DummyId) VALUES('{name}', {dummyId})";
                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Number of rows Inserted : " + result);

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
