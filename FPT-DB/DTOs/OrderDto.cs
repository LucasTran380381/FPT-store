using System;

namespace FptDB.DTOs
{
    public class OrderDto
    {
        public string Id { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public int StatusId { get; set; }
    }
}