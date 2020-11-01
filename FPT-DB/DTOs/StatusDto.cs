namespace FptDB.DTOs
{
    public class StatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StatusDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}