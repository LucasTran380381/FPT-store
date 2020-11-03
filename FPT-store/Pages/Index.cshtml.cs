using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using FptDB.DAOs;
using FptDB.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; }
        public List<ProductDto> Products { get; set; }
        public void OnGet()
        {
            IDao<ProductDto, string> productDao = new ProductDao();
            Products = productDao.GetAll();
            

            Console.Out.WriteLine($"{PageNum}");

            var hashPassword = Hash256("123");
            Console.Out.WriteLine($"{hashPassword}");
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