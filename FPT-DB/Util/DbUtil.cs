using Microsoft.Data.SqlClient;

namespace FptDB
{
    public class DbUtil
    {
        private const string ConnString =
            "Server=tcp:fpt-mobile.database.windows.net,1433;Initial Catalog=Mobile_DB;Persist Security Info=False;User ID=ftpadmin;Password=@Admin123123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static SqlConnection GetConn()
        {
            var sqlConnection = new SqlConnection(ConnString);
            return sqlConnection;
        }
    }
}