using FptDB.DAOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace FPT_store.Pages.Products
{
    public class Delete : PageModel
    {
        private readonly ProductDao _productDao;

        public Delete(ProductDao productDao)
        {
            _productDao = productDao;
        }

        public string Message { get; private set; }

        public IActionResult OnPost(string id)
        {
            try
            {
                var result = _productDao.Delete(id);
                if (!result) Message = "Delete Not Success";
            }
            catch (SqlException e)
            {
                Message = e.Message;
            }

            if (!string.IsNullOrEmpty(Message)) return Page();

            return RedirectToPage("/admin/index");
        }
    }
}