string name = "Mudassar Khan";
string city = "Pune";
string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
using (SqlConnection con = new SqlConnection(constring))
{
    using (SqlCommand cmd = new SqlCommand("UPDATE Persons SET City = @City WHERE Name = @Name", con))
    {
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@City", city);
        con.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        con.Close();
    }
}
