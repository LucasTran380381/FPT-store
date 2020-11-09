using System;
using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace FPT_store.Pages.Products
{
    [Authorize(Roles = "admin")]
    public class Edit : PageModel
    {
        private readonly ProductDao _productDao;

        public Edit(ProductDao productDao)
        {
            _productDao = productDao;
        }

        [BindProperty] public AddAndEditProductModel Model { get; set; }

        public string Message { get; set; }

        public void OnGet(string id)
        {
            try
            {
                var dto = _productDao.GetForAdmin(id);
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

        public IActionResult OnPost(string id)
        {
            if (!ModelState.IsValid) return Page();

            try
            {
                var dto = Model.ToDto();
                dto.Id = id;
                var isSuccess = _productDao.Update(dto);
                if (!isSuccess) Message = "Update not success";
            }
            catch (Exception e)
            {
                Message = e.Message;
            }

            if (!string.IsNullOrEmpty(Message))
            {
                Console.Out.WriteLine($"message: {Message}");
                return Page();
            }

            return RedirectToPage("/admin/index");
        }
    }
}