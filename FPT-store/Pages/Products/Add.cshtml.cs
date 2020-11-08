using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Products
{
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
            Message = "Update not success";

            if (ModelState.IsValid)
            {
                var dto = AddAndEditProductModel.ToDto();
                var isSaved = _productDao.Save(dto);

                if (isSaved) view = RedirectToPage("/admin/index");
            }

            return view;
        }
    }
}