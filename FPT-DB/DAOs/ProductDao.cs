using FptDB.DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FptDB.DAOs
{
    public class ProductDao
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

        public List<ProductDto> GetByBrand(string brandName)
        {
            var products = new List<ProductDto>();

            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand("GetProductsByBrand", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BrandName", brandName);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(initProduct(reader));
                        }
                    }
                }
            }

            return products;
        }

        private ProductDto initProduct(SqlDataReader reader)
        {
            var id = reader.GetString("id");
            var name = reader.GetString("name");
            var image = reader.GetString("image");
            var price = reader.GetDouble("price");
            var quantity = reader.GetInt32("quantity");
            var brandId = reader.GetInt32("brandId");
            var brandName = reader.GetString("brandName");
            var categoryId = reader.GetInt32("categoryId");
            var categoryName = reader.GetString("categoryName");
            var statusId = reader.GetInt32("statusId");
            var statusName = reader.GetString("statusName");

            return new ProductDto(id, name, quantity, image, price,
                new StatusDto(statusId, statusName),
                new CategoryDto(categoryId, categoryName),
                new BrandDto(brandId, brandName));
        }

        public List<ProductDto> GetTop(int offset)
        {
            throw new NotImplementedException();
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