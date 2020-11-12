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
    [Authorize(Roles = "customer")]
    public class Index : PageModel
    {
        private readonly OrderDao _orderDao;
        private readonly OrderDetailDao _orderDetailDao;
        private readonly ProductDao _productDao;
        private readonly StatusDao _statusDao;
        public List<OrderDto> Orders { get; set; }

        public Index(OrderDao orderDao, StatusDao statusDao, ProductDao productDao, OrderDetailDao orderDetailDao)
        {
            _orderDao = orderDao;
            _statusDao = statusDao;
            _productDao = productDao;
            _orderDetailDao = orderDetailDao;
        }

        public string Message { get; set; }

       

        public OrderSearchModel Model { get; set; }
        
        public void OnGet()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            Orders = _orderDao.GetByEmail(email);
        }

        public void OnGetSearch(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                Console.Out.WriteLine("true");
                return;
            }

            Console.Out.WriteLine($"{id}");
            var email = User.FindFirstValue(ClaimTypes.Email);
            var role = User.FindFirstValue(ClaimTypes.Role);

            try
            {
                OrderDto dto = null;
                if (role.Equals("customer"))
                    dto = _orderDao.Get(id, email);
                else
                    dto = _orderDao.Get(id);

                if (dto != null)
                {
                    var orderDetailDtos = _orderDetailDao.GetByOrderId(dto.Id);
                    if (orderDetailDtos != null) Model = InitModel(dto, orderDetailDtos);
                }
            }
            catch (Exception e)
            {
                Message = e.Message;
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