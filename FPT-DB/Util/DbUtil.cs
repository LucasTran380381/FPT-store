using Microsoft.Data.SqlClient;

namespace FptDB
{
    public class DbUtil
    {
        private const string ConnString = "";

        public static SqlConnection GetConn()
        {
            var sqlConnection = new SqlConnection(ConnString);
            return sqlConnection;
        }
    }
}