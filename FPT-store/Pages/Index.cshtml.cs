using System;
using System.Collections.Generic;
using FPT_store.Cart;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FPT_store.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public int PageNum { get; set; }
        public List<ProductDto> Products { get; set; }

        [BindProperty(SupportsGet = true)] public string SearchName { get; set; }

        [BindProperty] public ProductDto AddedProduct { get; set; }
        public CartObject Cart { get; set; }

        public List<BrandDto> Brands { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            if (SearchName != null)
            {
                Products = new ProductDao().GetProductsByName(SearchName);
            }
            else
            {
                Products = new ProductDao().GetAll();
            }

            Brands = new BrandDao().GetAll();
            Categories = new CategoryDao().GetAll();
        }

        public void OnGetFilterProduct(string data, string type)
        {
            if (!string.IsNullOrEmpty(data))
            {
                if (type.Equals("1"))
                {
                    Products = new ProductDao().GetByBrand(data);
                }

                if (type.Equals("0"))
                {
                    Products = new ProductDao().GetByCategory(data);
                }

                Brands = new BrandDao().GetAll();
                Categories = new CategoryDao().GetAll();
            }
            else
            {
                OnGet();
            }
        }

        public IActionResult OnPost()
        {
            string cartString = HttpContext.Session.GetString("cart");
            int quantity = new ProductDao().Get(AddedProduct.Id).Quantity;
            int quan = 0;
            if (cartString == null)
            {
                Cart = new CartObject();
            }
            else
            {
                Cart = JsonConvert.DeserializeObject<CartObject>(cartString);
            }

            if (Cart.GetItems() == null)
            {
                if (quantity > quan)
                {
                    Cart.AddItemToCart(AddedProduct);
                }
            }
            else if (Cart.GetItems() != null)
            {
                Dictionary<string, ProductDto> items = Cart.GetItems();
                if (items.ContainsKey(AddedProduct.Id))
                {
                    quan = items[AddedProduct.Id].Quantity + 1;
                    if (quantity >= quan)
                    {
                        Cart.AddItemToCart(AddedProduct);
                    }
                }
                else
                {
                    if (quantity > quan)
                    {
                        Cart.AddItemToCart(AddedProduct);
                    }
                }
            }
            cartString = JsonConvert.SerializeObject(Cart);

            HttpContext.Session.SetString("cart", cartString);

            foreach (var item in Cart.GetItems())
            {
                Console.WriteLine("name: " + item.Value.Name);
                Console.WriteLine("quantity: " + item.Value.Quantity);
            }
            
            return RedirectToPage("./Index");
        }
    }

    
}