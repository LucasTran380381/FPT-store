using FptDB.DTOs;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace FptDB.DAOs
{
    public class CategoryDao
    {
        public List<CategoryDto> GetAll()
        {
            var categories = new List<CategoryDto>();
            using (var connection = DbUtil.GetConn())
            {
                var sql = "select id, name from categories";
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32("id");
                            var name = reader.GetString("name");

                            categories.Add(new CategoryDto(id, name));
                        }
                    }
                }
            }
            return categories;
        }
    }
}
