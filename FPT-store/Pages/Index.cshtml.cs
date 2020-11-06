using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public int PageNum { get; set; }
        public List<ProductDto> Products { get; set; }

        public List<BrandDto> Brands { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public string Message { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }

        public void OnGet()
        {
            if (ProductName != null)
            {
                Console.WriteLine("Product name: " + ProductName);
                Products = new ProductDao().GetByName(ProductName);
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
                if (type.Equals("0"))
                {
                    Products = new ProductDao().GetByCategory(data);
                }
                
                if (type.Equals("1"))
                {
                    Products = new ProductDao().GetByBrand(data);
                }

                Categories = new CategoryDao().GetAll();
                Brands = new BrandDao().GetAll();
            }
            else
            {
                OnGet();
            }
        }
    }
}