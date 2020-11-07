namespace FptDB.DTOs
{
    public class CategoryDto
    {
        public CategoryDto(int id, string name = "DefaltCategory")
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}