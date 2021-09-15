string ConnectionString = "Integrated Security = SSPI;" + "Initial catalog = Northwind; " + " Data Source = localhost; ";  
string SQL = "SELECT CustomerID, CompanyName FROM Customers";  
SqlConenction conn = new SqlConnection(ConnectionString);  
  
// open the connection  
conn.Open();  
  
// Create a SqlDataAdapter object  
SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn); 
