namespace FptDB.DTOs
{
    public class BrandDto
    {
        public BrandDto(int id, string name = "DefaultBrand")
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}