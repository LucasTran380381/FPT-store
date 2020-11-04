using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FptDB.DTOs;

namespace FPT_store.Models.Admin
{
    public class AddProductModel
    {
        [StringLength(100, MinimumLength = 5)] public string ProductName { get; set; }
        [Required] public string Image { get; set; }
        [Range(10000, 1000000000)] public double Price { get; set; }
        [Range(1, 1000000000)] public int Quantity { get; set; }
        [StringLength(100, MinimumLength = 5)] public string Description { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public List<BrandDto> Brands { get; set; }
        public List<CategoryDto> Categories { get; set; }
    }
}