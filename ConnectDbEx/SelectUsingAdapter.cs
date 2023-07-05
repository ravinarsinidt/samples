using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDbEx
{
    internal class SelectUsingAdapter
    {
        public static void Select()
        {
            SqlConnection conn = new SqlConnection("Server=RAVINARSINI;Database='AudreeTraining';User Id=sa;Password=adminadmin;encrypt=false");
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Student", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int result = adapter.Fill(dataSet);
                if (result > 0 && dataSet.Tables.Count > 0)
                {
                    for(int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        Console.WriteLine("Id : " +  dataSet.Tables[0].Rows[i]["Id"]);
                        Console.WriteLine("Name : " + dataSet.Tables[0].Rows[i]["Name"]);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
