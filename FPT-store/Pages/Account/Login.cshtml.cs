using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
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
        public string Message { get; set; }
        public LoginModel LoginModel { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReturnUrl => "/Index";

        public void OnGet()
        {
            
        }
        
        public async Task<IActionResult> OnPost()
        {
            Console.Out.WriteLine("hello post");
            var authDao = new AuthDao();
            var accountDto = authDao.Authenticate(LoginModel.Email, LoginModel.Password);
            if (accountDto == null)
            {
                Message = "Invalid email or password";
                return Page();
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, accountDto.Email),
                    new Claim(ClaimTypes.Role, accountDto.Role.Name),
                    new Claim("fullName", accountDto.FullName),
                    new Claim(ClaimTypes.StreetAddress, accountDto.Address),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                var properties = new AuthenticationProperties();
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal,
                    properties);

                return Redirect(ReturnUrl ?? "/Index");
            }
        }
    }
}