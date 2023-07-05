using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class DeleteEx
    {
        public static void Delete()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = "DELETE FROM Student WHERE Id > 6";
                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    Console.WriteLine("Records succesfully Deleted : " + result);
                }
                else
                {
                    Console.WriteLine("Records not found with given criteria");
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
