using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

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
                var brandId = reader.GetInt32(6);
                var brandName = reader.GetString(7);
                var categoryId = reader.GetInt32(8);
                var categoryName = reader.GetString(9);
                var statusId = reader.GetInt32(10);
                var statusName = reader.GetString(11);
                var description = reader.GetString("description");

                products ??= new List<ProductDto>();

                products.Add(new ProductDto(id, name, quantity, image, price,
                    new StatusDto(statusId, statusName),
                    new CategoryDto(categoryId, categoryName),
                    new BrandDto(brandId, brandName), description));
            }

            return products;
        }
        public List<ProductDto> GetByCategory(string cateName)
        {
            var products = new List<ProductDto>();

            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand("GetProductsByCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryName", cateName);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read()) products.Add(initProduct(reader));
                    }
                }
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
                        while (reader.Read()) products.Add(initProduct(reader));
                    }
                }
            }

            return products;
        }

        public List<ProductDto> GetByName(string productName)
        {
            var products = new List<ProductDto>();

            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand("GetProductByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", productName);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read()) products.Add(initProduct(reader));
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
            var description = reader.GetString("description");

            return new ProductDto(id, name, quantity, image, price,
                new StatusDto(statusId, statusName),
                new CategoryDto(categoryId, categoryName),
                new BrandDto(brandId, brandName), description);
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