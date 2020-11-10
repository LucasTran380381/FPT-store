using System.Collections.Generic;
using System.Linq;
using Dapper;
using FptDB.DTOs;

namespace FptDB.DAOs
{
    public class OrderDetailDao
    {
        public List<OrderDetailDto> GetByOrderId(string orderId)
        {
            List<OrderDetailDto> list;
            using (var connection = DbUtil.GetConn())
            {
                var sql = @"select id, fk_products ProductId, fk_orders OrderId, quantity, price
                from order_details where fk_orders = @OrderId";
                list = connection.Query<OrderDetailDto>(sql, new {OrderId = orderId}).ToList();
            }

            return list;
        }
    }
}