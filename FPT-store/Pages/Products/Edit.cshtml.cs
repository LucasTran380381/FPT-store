using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace FPT_store.Pages.Products
{
    public class Edit : PageModel
    {
        private readonly ProductDao _productDao;

        public Edit(ProductDao productDao, AddAndEditProductModel model)
        {
            _productDao = productDao;
            Model = model;
        }

        [BindProperty] public AddAndEditProductModel Model { get; set; }

        public string Message { get; set; }

        public void OnGet(string id)
        {
            try
            {
                var dto = _productDao.Get(id);
                if (dto == null)
                    Message = $"Can Not Get Product id: {id}";
                else
                    Model = AddAndEditProductModel.FromDto(dto);
            }
            catch (SqlException e)
            {
                Message = e.Message;
            }
        }
    }
}