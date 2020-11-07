namespace FptDB.DTOs
{
    public class ProductDto
    {
        public ProductDto(string id, string name, int quantity, string image, double price, StatusDto status,
            CategoryDto category, BrandDto brand, string description)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Image = image;
            Price = price;
            Status = status;
            Category = category;
            Brand = brand;
            Description = description;
        }

        public ProductDto()
        {
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public StatusDto Status { get; set; }

        public CategoryDto Category { get; set; }

        public BrandDto Brand { get; set; }
        public string Description { get; set; }
    }
}