using FPT_store.Models.Admin;
using FptDB.DAOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Admin
{
    public class AddProduct : PageModel
    {
        public AddProductModel AddProductModel { get; set; }

        public void OnGet()
        {
            AddProductModel.Brands = new BrandDao().GetAll();
        }
    }
}