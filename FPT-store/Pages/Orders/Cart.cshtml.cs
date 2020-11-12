using System;
using System.Collections.Generic;
using System.Security.Claims;
using FPT_store.Cart;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FPT_store.Pages.Orders
{
    [Authorize(Roles = "customer, employee")]
    public class Order : PageModel
    {
        public Dictionary<string, ProductDto> Items { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            // get cart
            CartObject cart = null;
            string cartStr = HttpContext.Session.GetString("cart");
            if (cartStr != null)
            {
                cart = JsonConvert.DeserializeObject<CartObject>(cartStr);
                if (cart != null)
                {
                    if (cart.GetItems() != null)
                    {
                        Total = cart.GetTotal();
                        Items = cart.GetItems();
                    }
                }
            }
        }

        public void OnGetDeleteItem(string id)
        {
            if (id != null)
            {
                CartObject cart = null;
                string cartStr = HttpContext.Session.GetString("cart");
                if (cartStr != null)
                {
                    cart = JsonConvert.DeserializeObject<CartObject>(cartStr);
                    if (cart != null)
                    {
                        if (cart.GetItems() != null)
                        {
                            cart.RemoveItem(id);
                            cartStr = JsonConvert.SerializeObject(cart);
                            HttpContext.Session.SetString("cart", cartStr);
                        }
                    }
                }
            }

            OnGet();
        }
        
        public IActionResult OnPost()
        {
            string id = "";
            CartObject cart = null;
            string cartStr = HttpContext.Session.GetString("cart");
            if (cartStr != null)
            {
                cart = JsonConvert.DeserializeObject<CartObject>(cartStr);
                if (cart != null)
                {
                    if (cart.GetItems() != null)
                    {
                        var email = User.FindFirstValue(ClaimTypes.Email);

                        bool result = new ProductDao().UpdateQuantity(cart.GetItems());
                        if (result)
                        {
                            DateTime now = DateTime.Now;
                            OrderDto dto = new OrderDto
                            {
                                Date = now,
                                Email = email,
                                Id = "",
                                Total = cart.GetTotal(),
                                StatusId = 1
                            };
                            new OrderDao().AddOrder(dto);
                            id = new OrderDao().GetOrderId(dto);
                            if (id != null)
                            {
                                Dictionary<string, ProductDto> items = cart.GetItems();
                                foreach (var key in items.Keys)
                                {
                                    OrderDetailDto detail = new OrderDetailDto
                                    {
                                        Id = 0,
                                        OrderId = id,
                                        Price = items[key].Price,
                                        Quantity = items[key].Quantity,
                                        ProductId = items[key].Id
                                    };
                                    new OrderDetailDao().AddOrderDetail(detail);
                                }
                            }
                        }
                        
                        HttpContext.Session.Remove("cart");
                    }
                }
            }
            
            return RedirectToPage("/Orders/Cart", "OrderDetail");
        }

        public void OnGetOrderDetail()
        {
            Status = "success";
            OnGet();
        }
    }
}