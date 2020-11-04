using System.Collections.Generic;
using System.Data;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    internal class CategoryDao
    {
        public List<CategoryDto> GetAll()
        {
            var categories = new List<CategoryDto>();
            using (var connection = DbUtil.GetConn())
            {
                var query = "select id, name from categories";
                using (var command = new SqlCommand(query, connection))
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