using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public ProductDto GetForAdmin(string id)
        {
            ProductDto dto = null;
            using (var connection = DbUtil.GetConn())
            {
                var sql = @"select products.*, brands.*, status.*, categories.*
                from products,
                    brands,
                    status,
                    categories
                where products.fk_brand = brands.id
                and products.fk_categories = categories.id
                and products.fk_status = status.id
                and products.id = @Id";
                var param = new
                {
                    Id = id
                };
                var list = connection.Query<ProductDto, BrandDto, StatusDto, CategoryDto, ProductDto>(sql,
                    (productDto, brandDto, status, category) =>
                    {
                        productDto.Brand = brandDto;
                        productDto.Status = status;
                        productDto.Category = category;
                        return productDto;
                    }, param).ToList();

                if (list.Count > 0) dto = list.First();
            }

            return dto;
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

        public bool Update(ProductDto dto)
        {
            bool isSuccess;
            using (var connection = DbUtil.GetConn())
            {
                const string sql = @"update products
                set name = @Name,
                    image = @Image,
                    price = @Price,
                    quantity = @Quantity,
                    description = @Description,
                    fk_status = @StatusId,
                    fk_categories = @CategoryId,
                    fk_brand = @BrandId
                where id = @Id";
                var param = new
                {
                    dto.Id, dto.Name, dto.Image, dto.Price, dto.Quantity, dto.Description,
                    StatusId = dto.Status.Id,
                    CategoryId = dto.Category.Id,
                    BrandId = dto.Brand.Id
                };
                isSuccess = connection.Execute(sql, param) > 0;
            }

            return isSuccess;
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

        public List<ProductDto> GetProductsByName(string productName)
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

        public bool UpdateQuantity(Dictionary<string, ProductDto> list)
        {
            var result = false;
            using (var connection = DbUtil.GetConn())
            {
                connection.Open();

                // Start a local transaction.
                var sqlTran = connection.BeginTransaction();

                // Enlist a command in the current transaction.
                var cmd = connection.CreateCommand();
                cmd.Transaction = sqlTran;
                cmd.Connection = connection;
                try
                {
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar);
                    // Execute two separate commands.
                    foreach (var key in list.Keys)
                    {
                        cmd.CommandText = "update products set quantity = (quantity - @Quantity) where id = @Id";
                        cmd.Parameters["@Quantity"].Value = list[key].Quantity;
                        cmd.Parameters["@Id"].Value = key;

                        cmd.ExecuteNonQuery();
                    }

                    // Commit the transaction.
                    sqlTran.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    // Handle the exception if the transaction fails to commit.
                    result = false;
                    try
                    {
                        // Attempt to roll back the transaction.
                        sqlTran.Rollback();
                    }
                    catch (Exception)
                    {
                        // Throws an InvalidOperationException if the connection
                        // is closed or the transaction has already been rolled
                        // back on the server.
                        result = false;
                    }
                }

                return result;
            }
        }
    }
}