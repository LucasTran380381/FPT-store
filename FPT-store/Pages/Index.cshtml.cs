using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Net;
using System.Security.Claims;
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
        }
    }
}