using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conObj = new SqlConnection(@"data source = (localdb)\ProjectsV13;database=AdventureWorks2012;integrated security=SSPI");
            SqlCommand queryObj = new SqlCommand(@"EXEC usp_InsertData 'Sales and marketing', 'Manufacturing', '2021-09-15'", conObj);
            conObj.Open();
            queryObj.ExecuteNonQuery();
            conObj.Close();
        }
    }
}
