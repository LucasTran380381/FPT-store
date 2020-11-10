namespace FptDB.DTOs
{
    public class OrderDetailDto
    {
        public OrderDetailDto(int id, string productId, string orderId, int quantity, float price)
        {
            Id = id;
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
            Price = price;
        }

        public OrderDetailDto()
        {
        }

        public int Id { get; set; }
        public string ProductId { get; set; }
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}