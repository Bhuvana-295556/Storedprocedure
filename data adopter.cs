using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Read
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string ConnectionString = "Integrated Security = SSPI; " + @" Data source = (localDB)\ProjectsV13; " + " Database = AdventureWorks2012";
                string SQL = "SELECT * FROM HumanResources.Department";

                SqlConnection conn = new SqlConnection(ConnectionString);

                SqlCommand cmd = new SqlCommand(SQL, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Department ID, Name, " + "Group Name");
                Console.WriteLine("=============================");

                while (reader.Read())
                {
                    Console.Write(reader["DepartmentID"].ToString() + ", ");
                    Console.Write(reader["Name"].ToString() + ", ");
                    Console.Write(reader["GroupName"].ToString() + ", ");
                    //Console.WriteLine(reader["Address"].ToString() + ", ");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
        
                Console.WriteLine("OOPS!! An Error Occurred!!");
                throw;
            }
        }
    }
}
