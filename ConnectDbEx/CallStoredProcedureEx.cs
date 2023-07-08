using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class CallStoredProcedureEx
    {
        public static void Select()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.GetData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                //SqlParameter idParam = new SqlParameter();
                //idParam.ParameterName = "Id";
                //idParam.Value = 1;
                //idParam.DbType = DbType.Int32;

                //cmd.Parameters.Add(idParam);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                int result = adapter.Fill(dataSet);

                if (dataSet.Tables.Count > 0)
                {
                    DataTable stable = dataSet.Tables[0];
                    PrintStudentData(stable);


                    DataTable ctable = dataSet.Tables["Course"];
                    PrintStudentData(ctable);

                    //for (int i = 0; i < dataSet.Tables.Count; i++)
                    //{
                    //    if(i == 0) // Student Table
                    //    {
                    //        Console.Write("Student Table Data");
                    //        for (int j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                    //        {
                    //            Console.WriteLine("Id : " + dataSet.Tables[i].Rows[j]["Id"]);
                    //            Console.WriteLine("Name : " + dataSet.Tables[i].Rows[j]["Name"]);
                    //        }
                    //    }
                    //    if (i == 1) // Course Table
                    //    {
                    //        Console.Write("Course Table Data");
                    //        for (int j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                    //        {
                    //            Console.WriteLine("Id : " + dataSet.Tables[i].Rows[j]["Id"]);
                    //            Console.WriteLine("Name : " + dataSet.Tables[i].Rows[j]["Name"]);
                    //        }
                    //    }
                    //    if (i == 2) // StudentCourse Table
                    //    {
                    //        Console.Write("Student-Course Table Data");
                    //        for (int j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                    //        {
                    //            Console.WriteLine("Student Id : " + dataSet.Tables[i].Rows[j]["StudentId"]);
                    //            Console.WriteLine("Course Id : " + dataSet.Tables[i].Rows[j]["CourseId"]);
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        private static void PrintStudentData(DataTable table)
        {
            Console.WriteLine("Table Name : " + table.TableName);
            for (int j = 0; j < table.Rows.Count; j++)
            {
                Console.WriteLine("Id : " + table.Rows[j]["Id"]);
                Console.WriteLine("Name : " + table.Rows[j]["Name"]);
            }
        }
    }
}
