using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Net;
using FPT_store.Models;
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
            product.Id = "1";
            
        }
    }
}