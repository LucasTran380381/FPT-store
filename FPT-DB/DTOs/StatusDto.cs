namespace FptDB.DTOs
{
    public class StatusDto
    {
        public StatusDto(int id, string name = "activated")
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}