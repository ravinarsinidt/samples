using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgmt
{
    internal class InsertEx
    {
        public static int Insert(Student newStudent)
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");

            try
            {
                string insertCommand = $"INSERT INTO Student(Name, DummyId) VALUES('{newStudent.Name}', {newStudent.DummyId})";
                SqlCommand cmd = new SqlCommand(insertCommand, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Number of rows Inserted : " + result);
                return result;
            }
            catch (Exception ex)
            {
                return  -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
