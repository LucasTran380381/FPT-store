namespace FptDB.DTOs
{
    public class RoleDto
    {
        public RoleDto(int id, string name = "customer")
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}