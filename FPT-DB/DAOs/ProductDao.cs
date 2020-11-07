using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
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
                products ??= new List<ProductDto>();

                products.Add(initProduct(reader));
            }

            return products;
        }

        public List<ProductDto> GetAllForAd()
        {
            var products = new List<ProductDto>();

            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand("GetAllProductsForAd", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read()) products.Add(initProduct(reader));
                    }
                }
            }

            return products;
        }

        public List<ProductDto> GetByCategory(string cateName)
        {
            var products = new List<ProductDto>();

            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand())
                {
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
            ProductDto product = null;
            using (var connection = DbUtil.GetConn())
            {
                using (var command = new SqlCommand("GetProductById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) product = initProduct(reader);
                    }
                }
            }

            return product;
        }

        public bool Save(ProductDto dto)
        {
            bool result;
            using IDbConnection connection = DbUtil.GetConn();
            var sql =
                "insert products (name, image, price, quantity, fk_status, fk_categories, fk_brand, description) values (@Name, @Image, @Price, @Quantity, @StatusId, @CategoryId, @BrandId,@Description)";
            var param = new
            {
                dto.Name, dto.Image, dto.Price, dto.Quantity, StatusId = dto.Status.Id,
                CategoryId = dto.Category.Id, BrandId = dto.Brand.Id, dto.Description
            };
            result = connection.Execute(sql, param) > 0;

            return result;
        }

        public bool Update(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            using IDbConnection connection = DbUtil.GetConn();
            const string sql = "update products set fk_status =2 where id = @Id";
            var param = new
            {
                Id = id
            };
            var result = connection.Execute(sql, param) > 0;

            return result;
        }
    }
}