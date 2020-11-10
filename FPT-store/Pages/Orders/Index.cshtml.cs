using System;
using System.Collections.Generic;
using System.Security.Claims;
using FPT_store.Models;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Orders
{
    [Authorize(Roles = "customer, employee")]
    public class Index : PageModel
    {
        private readonly OrderDao _orderDao;
        private readonly OrderDetailDao _orderDetailDao;
        private readonly ProductDao _productDao;
        private readonly StatusDao _statusDao;

        public Index(OrderDao orderDao, StatusDao statusDao, ProductDao productDao, OrderDetailDao orderDetailDao)
        {
            _orderDao = orderDao;
            _statusDao = statusDao;
            _productDao = productDao;
            _orderDetailDao = orderDetailDao;
        }

        public OrderSearchModel Model { get; set; }

        public void OnGetSearch(string id)
        {
            Console.Out.WriteLine($"id {id}");
            var email = User.FindFirstValue(ClaimTypes.Email);
            var dto = _orderDao.Get(id, email);
            if (dto != null)
            {
                var dtoEmail = dto.Email;
                Console.Out.WriteLine($"{dtoEmail}");
                var orderDetailDtos = _orderDetailDao.GetByOrderId(dto.Id);
                if (orderDetailDtos != null) Model = InitModel(dto, orderDetailDtos);
            }
        }

        private OrderSearchModel InitModel(OrderDto dto, List<OrderDetailDto> orderDetails)
        {
            var model = new OrderSearchModel
            {
                Id = dto.Id,
                Email = dto.Email,
                Total = dto.Total,
                Status = _statusDao.GetName(dto.StatusId),
                Date = dto.Date,
                OrderDetails = InitOrderDetailsModel(orderDetails)
            };

            return model;
        }

        private List<OrderDetailModel> InitOrderDetailsModel(List<OrderDetailDto> dtos)
        {
            var list = new List<OrderDetailModel>();
            foreach (var dto in dtos)
            {
                var model = new OrderDetailModel
                {
                    Price = dto.Price,
                    Quantity = dto.Quantity,
                    ProductName = _productDao.Get(dto.ProductId).Name
                };
                list.Add(model);
            }

            return list;
        }
    }
}