<<<<<<< HEAD
﻿using FptDB.DTOs;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
=======
﻿using System.Collections.Generic;
using System.Data;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;
>>>>>>> master

namespace FptDB.DAOs
{
    public class CategoryDao
    {
        public List<CategoryDto> GetAll()
        {
            var categories = new List<CategoryDto>();
<<<<<<< HEAD
            using (var connection = DbUtil.GetConn())
            {
                var sql = "select id, name from categories";
                using (var command = new SqlCommand(sql, connection))
=======
            IDbConnection cnn = DbUtil.GetConn();
            using (var connection = DbUtil.GetConn())
            {
                var query = "select id, name from categories";
                using (var command = new SqlCommand(query, connection))
>>>>>>> master
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
<<<<<<< HEAD
=======

>>>>>>> master
            return categories;
        }
    }
}