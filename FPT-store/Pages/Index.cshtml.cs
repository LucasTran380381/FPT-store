using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using FPT_store.Models;
using FptDB.DAOs;
using Microsoft.AspNetCore.Authentication;

namespace FPT_store.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var product = new Product();

            var authenticated = HttpContext.User.Identity.IsAuthenticated;

            Console.Out.WriteLine($"is loggin {authenticated}");

            var hash256 = Hash256("123");
            Console.Out.WriteLine($"{hash256}");
        }
        
        public static string Hash256(string password)
        {
            string hashPassword = null;
            using (var sha256 = SHA256.Create())
            {
                var input = Encoding.UTF8.GetBytes(password);
                hashPassword = BitConverter.ToString(sha256.ComputeHash(input));
            }

            return hashPassword;
        }
    }
}