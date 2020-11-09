using System;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Products
{
    public class Index : PageModel
    {
        private readonly ProductDao _productDao;

        public Index(ProductDao productDao)
        {
            _productDao = productDao;
        }

        public ProductDto Product { get; private set; }

        public string Message { get; set; }

        public void OnGet(string id)
        {
            try
            {
                _productDao.Get(id);
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
        }
    }
}