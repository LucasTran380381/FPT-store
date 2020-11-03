using System;
using System.Collections.Generic;
using System.Data;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    public class BrandDao
    {
        public List<BrandDto> GetAll()
        {
            var brands = new List<BrandDto>();
            using (var connection = DbUtil.GetConn())
            {
                var sql = "select id, name from brands";
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32("id");
                            var name = reader.GetString("name");

                            brands.Add(new BrandDto(id, name));
                        }
                    }
                }
            }

            return brands;
        }

        public List<BrandDto> GetTop(int offset)
        {
            throw new NotImplementedException();
        }

        public BrandDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(BrandDto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(BrandDto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}