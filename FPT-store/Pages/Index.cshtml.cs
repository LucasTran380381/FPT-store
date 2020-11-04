using System.Collections.Generic;
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

        public void OnGet()
        {
            Products = new ProductDao().GetAll();
            Brands = new BrandDao().GetAll();
        }

        public void OnGetFilterProduct(string brand)
        {
            if (!string.IsNullOrEmpty(brand))
            {
                Products = new ProductDao().GetByBrand(brand);
                Brands = new BrandDao().GetAll();
            }
            else
            {
                OnGet();
            }
        }
    }
}