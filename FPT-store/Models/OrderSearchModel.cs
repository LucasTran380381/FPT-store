using System;
using System.Collections.Generic;

namespace FPT_store.Models
{
    public class OrderSearchModel
    {
        public string Id { get; set; }
        public double Total { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; }
    }
}