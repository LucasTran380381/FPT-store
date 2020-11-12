using FptDB.DAOs;
using FptDB.DTOs;

namespace FPT_store.Models
{
    public class OrderDetailModel
    {
        private readonly ProductDao _productDao;

        public OrderDetailModel(ProductDao productDao)
        {
            _productDao = productDao;
        }

        public OrderDetailModel()
        {
        }

        public OrderDetailModel(string productName, int quantity, double price)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Amount => Quantity * Price;


        public OrderDetailModel FromDto(OrderDetailDto dto)
        {
            var model = new OrderDetailModel();
            {
                model.Quantity = dto.Quantity;
                model.Price = dto.Price;
                model.ProductName = _productDao.Get(dto.ProductId).Name;
            }
            return model;
        }
    }
}