using System.Configuration;
using System.Data.SqlClient;

namespace MultiTierContactList_Project.DAL
{
    internal class DatabaseConnection
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;
        private static SqlConnection sqlConnection = null;

        public static SqlConnection GetConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);
            }

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            return sqlConnection;
        }

        public static void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
