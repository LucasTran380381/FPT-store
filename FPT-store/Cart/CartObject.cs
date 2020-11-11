
using System;
using System.Collections.Generic;
using System.Linq;
using FptDB.DTOs;

namespace FPT_store.Cart
{
    public class CartObject
    {
        public Dictionary<string, ProductDto> Items { get; set; }

        public Dictionary<string, ProductDto> GetItems()
        {
            return this.Items;
        }

        public void AddItemToCart(ProductDto item)
        {
            if (this.Items == null)
            {
                this.Items = new Dictionary<string, ProductDto>();
            }

            int quantity = 1;
            if (this.Items.ContainsKey(item.Id))
            {
                quantity = this.Items[item.Id].Quantity + 1;
                Items[item.Id].Quantity = quantity;
            }
            else
            {
                item.Quantity = quantity;
                Items.Add(item.Id, item);
            }

        }
    }
}