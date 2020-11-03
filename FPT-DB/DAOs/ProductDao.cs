using System;
using System.Collections.Generic;
using System.Data;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    public class ProductDao : IDao<ProductDto, string>
    {
        public List<ProductDto> GetAll()
        {
            List<ProductDto> products = null;
            using var connection = DbUtil.GetConn();
            using var command = new SqlCommand("GetAllProducts", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetString("id");
                var name = reader.GetString("name");
                var image = reader.GetString(2);
                var price = reader.GetDouble("price");
                var quantity = reader.GetInt32(4);
                var brandId = reader.GetInt32(5);
                var brandName = reader.GetString(6);
                var categoryId = reader.GetInt32(7);
                var categoryName = reader.GetString(8);
                var statusId = reader.GetInt32(9);
                var statusName = reader.GetString(10);


                products ??= new List<ProductDto>();

                products.Add(new ProductDto(id, name, quantity, image, price,
                    new StatusDto(statusId, statusName),
                    new CategoryDto(categoryId, categoryName),
                    new BrandDto(brandId, brandName)));
            }

            return products;
        }

        public List<ProductDto> GetTop(int offset)
        {
            List<ProductDto> products = null;

            using (var connection = DbUtil.GetConn())
            {
                string sql = "";
                using (var command = new SqlCommand("",connection))
                {
                    
                }
            }

            return products;
        }

        public ProductDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Save(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}