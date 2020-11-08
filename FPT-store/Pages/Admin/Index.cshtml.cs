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
        private readonly ProductDao _productDao;

        public Index(ProductDao productDao)
        {
            _productDao = productDao;
        }

        public List<ProductDto> Products { get; private set; }

        public void OnGet()
        {
            Products = _productDao.GetAllForAd();
        }
    }
}