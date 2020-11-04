using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Products
{
    public class Index : PageModel
    {
        public ProductDto Product { get; private set; }

        public void OnGet(string id)
        {
            Product = new ProductDao().Get(id);
        }
    }
}