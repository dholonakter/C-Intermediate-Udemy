// See https://aka.ms/new-console-template for more information
using Database;

DbConnection dbConnection = new SqlConnection("new connection string");
dbConnection.Open();
dbConnection.Close();
dbConnection = new OracleConnection("new connection string");
dbConnection.Open();
dbConnection.Close();