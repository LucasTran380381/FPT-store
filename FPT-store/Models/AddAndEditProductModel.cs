using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using FptDB.DAOs;
using FptDB.DTOs;

namespace FPT_store.Models
{
    public class AddAndEditProductModel
    {
        [StringLength(100, MinimumLength = 5)] public string ProductName { get; set; }
        [Required] public string Image { get; set; }
        [Range(10000, 1000000000)] public double Price { get; set; }
        [Range(1, 1000000000)] public int Quantity { get; set; }
        [StringLength(100, MinimumLength = 5)] public string Description { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public List<BrandDto> Brands => new BrandDao().GetAll();

        public List<CategoryDto> Categories => new CategoryDao().GetAll();


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public ProductDto ToDto()
        {
            var dto = new ProductDto(null, ProductName, Quantity, Image, Price, new StatusDto(StatusId),
                new CategoryDto(CategoryId), new BrandDto(BrandId), Description);

            return dto;
        }

        public static AddAndEditProductModel FromDto(ProductDto dto)
        {
            var model = new AddAndEditProductModel
            {
                ProductName = dto.Name,
                Image = dto.Image,
                Price = dto.Price,
                Quantity = dto.Quantity,
                Description = dto.Description,
                StatusId = dto.Status.Id,
                CategoryId = dto.Category.Id,
                BrandId = dto.Brand.Id
            };

            return model;
        }
    }
}