using Dapper;

namespace FptDB.DAOs
{
    public class StatusDao
    {
        public string GetName(int id)
        {
            string name;
            using (var connection = DbUtil.GetConn())
            {
                var param = new
                {
                    Id = id
                };

                var sql = @"select name
                            from status where id = @Id";
                name = connection.QuerySingle<string>(sql, param);
            }

            return name;
        }
    }
}