
using Microsoft.Data.SqlClient;

namespace ATM
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
