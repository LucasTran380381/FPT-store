using System;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Products
{
    public class Index : PageModel
    {
        public ProductDto Product { get; set; }
        
        public void OnGet(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                Console.Out.WriteLine("true null");
            }

            Product = new ProductDao().Get(id);
        }
    }
}