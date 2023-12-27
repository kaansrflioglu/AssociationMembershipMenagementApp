using System.Data.OleDb;
using System.Data;

namespace DataAccessLayer
{
    public class DataAccessLayer
    {
        private readonly string connectionString;

        public DataAccessLayer()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
        }

        public DataTable ExecuteQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }

                return dataTable;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                int affectedRows = 0;
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    affectedRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }

                return affectedRows;
            }
        }
    }
}
