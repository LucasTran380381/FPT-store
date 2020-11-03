using System;
using System.Security.Cryptography;
using System.Text;
using FPT_store.Models;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Account
{
    [BindProperties]
    public class Register : PageModel
    {
        public RegisterModel RegisterModel { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            IDao<AccountDto, string> dao = new AccountDao();

            var account = new AccountDto(RegisterModel.Email, Hash256(RegisterModel.Password), RegisterModel.Name, RegisterModel.Address,
                RegisterModel.Phone, new RoleDto(1, "customer"), new StatusDto(1, "actived"));

            bool result = false;
            try
            {
                result = dao.Save(account);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("PRIMARY KEY"))
                {
                    Message = $"{RegisterModel.Email} not available for use";
                } else if (e.Message.Contains("'accounts_phone_uindex"))
                {
                    Message = $"{RegisterModel.Phone} has been use";
                }
            }

            if (!result)
            {
                return Page();
            }
             
            return RedirectToPage("Login");
        }

        private static string Hash256(string password)
        {
            string hashPassword;
            using var sha256 = SHA256.Create();
            var input = Encoding.UTF8.GetBytes(password ??= "");
            hashPassword = BitConverter.ToString(sha256.ComputeHash(input));

            return hashPassword;
        }
    }
}