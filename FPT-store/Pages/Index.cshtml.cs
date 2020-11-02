using System;
using System.Security.Cryptography;
using System.Text;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            IDao<ProductDto, string> productDao = new ProductDao();
            var products = productDao.GetAll();
            foreach (var productDto in products) Console.Out.WriteLine($"{productDto.Name}");
        }

        public static string Hash256(string password)
        {
            string hashPassword;
            using (var sha256 = SHA256.Create())
            {
                var input = Encoding.UTF8.GetBytes(password);
                hashPassword = BitConverter.ToString(sha256.ComputeHash(input));
            }

            return hashPassword;
        }
    }
}