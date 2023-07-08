using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgmt
{
    internal class SelectEx
    {
        public static List<Student> GetStudents()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");
            List<Student> result = new List<Student>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Student", conn);
                SqlDataReader rdr = null;
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Student s = new Student();

                    s.Id = int.Parse(rdr["Id"].ToString());
                    s.Name = rdr["Name"].ToString();
                    s.DummyId = int.Parse(rdr["DummyId"].ToString());
                    result.Add(s);
                }

                return result;

            }
            catch (Exception ex)
            {
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
