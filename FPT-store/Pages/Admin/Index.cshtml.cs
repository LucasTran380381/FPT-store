using System.Collections.Generic;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class Index : PageModel
    {
        public List<ProductDto> Products { get; set; }

        public void OnGet()
        {
            Products = new ProductDao().GetAllForAd();
        }
    }
}