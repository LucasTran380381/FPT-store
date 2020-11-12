using System.Collections.Generic;
using FPT_store.Models;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Orders
{
    public class Detail : PageModel
    {
        private readonly OrderDao _orderDao;
        private readonly OrderDetailDao _orderDetailDao;
        private readonly ProductDao _productDao;

        public List<OrderDetailModel> OrderDetailModels { get; set; }

        public OrderModel OrderModel { get; set; }

        public Detail(OrderDao orderDao, OrderDetailDao orderDetailDao, ProductDao productDao)
        {
            _orderDao = orderDao;
            _orderDetailDao = orderDetailDao;
            _productDao = productDao;
        }

        public void OnGet(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var orderDto = _orderDao.Get(id);
                if (orderDto != null)
                {
                    OrderModel = InitOrderModel(orderDto);
                    var orderDetailDtos = _orderDetailDao.GetByOrderId(id);
                    if (orderDetailDtos != null)
                    {
                        OrderDetailModels = InitOrderDetailModels(orderDetailDtos);
                    }
                }
            }
        }

        private OrderModel InitOrderModel(OrderDto dto)
        {
            return new OrderModel()
            {
                Id = dto.Id,
                Email = dto.Email,
                Date = dto.Date,
                Total = dto.Total,
            };
        }

        private List<OrderDetailModel> InitOrderDetailModels(List<OrderDetailDto> dtos)
        {
            List<OrderDetailModel> orderDetailModels = new List<OrderDetailModel>();
            foreach (var dto in dtos)
            {
                orderDetailModels.Add(new OrderDetailModel()
                {
                    Price = dto.Price,
                    ProductName = _productDao.Get(dto.ProductId).Name,
                    Quantity = dto.Quantity
                });
            }

            return orderDetailModels;
        }
    }
}