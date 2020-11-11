using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Account
{
    [BindProperties]
    public class Login : PageModel
    {
        public string Message { get; private set; }
        public LoginModel LoginModel { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl)
        {
            var authDao = new AuthDao();
            var accountDto = authDao.Authenticate(LoginModel.Email, Hash256(LoginModel.Password));
            if (accountDto == null)
            {
                Message = "Invalid email or password";
                return Page();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, accountDto.Email),
                new Claim(ClaimTypes.Role, accountDto.Role.Name),
                new Claim(ClaimTypes.Name, accountDto.FullName),
                new Claim(ClaimTypes.StreetAddress, accountDto.Address),
                new Claim(ClaimTypes.MobilePhone, accountDto.Phone)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            var properties = new AuthenticationProperties();
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal,
                properties);

            if (accountDto.Role.Name.Equals("admin")) returnUrl = "/Admin/Index";
            return Redirect(returnUrl ?? "/Index");
        }

        private static string Hash256(string password)
        {
            string hashPassword;
            using (var sha256 = SHA256.Create())
            {
                var input = Encoding.UTF8.GetBytes(password ?? "");
                hashPassword = BitConverter.ToString(sha256.ComputeHash(input));
            }

            return hashPassword;
        }
    }
}