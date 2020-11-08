using System;
using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Products
{
    [Authorize(Roles = "admin")]
    public class Add : PageModel
    {
        private readonly ProductDao _productDao;

        public Add(ProductDao productDao)
        {
            _productDao = productDao;
        }

        public string Message { get; private set; }

        [BindProperty] public AddAndEditProductModel AddAndEditProductModel { get; set; }

        public void OnGet()
        {
            AddAndEditProductModel = new AddAndEditProductModel();
        }

        public IActionResult OnPost()
        {
            IActionResult view = Page();

            if (ModelState.IsValid)
                try
                {
                    var dto = AddAndEditProductModel.ToDto();
                    var isSaved = _productDao.Save(dto);
                    if (isSaved) view = RedirectToPage("/admin/index");
                }
                catch (Exception e)
                {
                    Message = e.Message;
                }

            return view;
        }
    }
}