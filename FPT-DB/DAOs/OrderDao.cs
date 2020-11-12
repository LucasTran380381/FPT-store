using System.Collections.Generic;
using System.Linq;
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

        public List<OrderDto> GetByEmail(string email)
        {
            List<OrderDto> orders;
            using (var connection = DbUtil.GetConn())
            {
                var sql = @"select *
                from orders where fk_accounts = @Email order by date desc";
                orders = connection.Query<OrderDto>(sql, new {email}).ToList();
            }

            return orders;
        }

        public bool AddOrder(OrderDto dto)
        {
            using (var connection = DbUtil.GetConn())
            {
                var sql =
                    "insert orders (total, date, fk_accounts, fk_status) values (@Total, @Date, @Email, @StatusId)";
                var param = new
                {
                    dto.Total, dto.Date, dto.Email, dto.StatusId
                };
                var result = connection.Execute(sql, param) > 0;
                return result;
            }
        }

        public string GetOrderId(OrderDto dto)
        {
            using (var connection = DbUtil.GetConn())
            {
                var sql = @"select id Id
                from orders
                where date = @Date
                and fk_status = 1 
                and fk_accounts = @Account";

                var param = new
                {
                    dto.Date,
                    Account = dto.Email
                };
                var id = connection.QuerySingleOrDefault<string>(sql, param);
                return id;
            }
        }
    }
}