using System.Collections.Generic;
using System.Linq;
using Dapper;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

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

        public bool AddOrderDetail(OrderDetailDto dto)
        {
            using (var connection = DbUtil.GetConn())
            {
                string sql =
                    "insert order_details (fk_products, fk_orders, quantity, price) values (@ProductId, @OrdersId, @Quantity, @price)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ProductId", dto.ProductId);
                cmd.Parameters.AddWithValue("@OrdersId", dto.OrderId);
                cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
                cmd.Parameters.AddWithValue("@price", dto.Price);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}