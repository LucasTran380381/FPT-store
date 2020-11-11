using Dapper;
using FptDB.DTOs;

namespace FptDB.DAOs
{
    public class OrderDao
    {
        public OrderDto Get(string id, string email)
        {
            OrderDto dto;
            using (var connection = DbUtil.GetConn())
            {
                var sql =
                    @"select id Id, total Total, date Date, fk_accounts Email, fk_status StatusId
                from orders
                where id = @Id
                and fk_status = 1
                and fk_accounts = @Email";

                var param = new
                {
                    Id = id, Email = email
                };
                dto = connection.QuerySingleOrDefault<OrderDto>(sql, param);
            }

            return dto;
        }


        public OrderDto Get(string id)
        {
            OrderDto dto;
            using (var connection = DbUtil.GetConn())
            {
                var sql =
                    @"select id Id, total Total, date Date, fk_accounts Email, fk_status StatusId
                from orders
                where id = @Id
                and fk_status = 1";

                var param = new
                {
                    Id = id
                };
                dto = connection.QuerySingleOrDefault<OrderDto>(sql, param);
            }

            return dto;
        }
    }
}