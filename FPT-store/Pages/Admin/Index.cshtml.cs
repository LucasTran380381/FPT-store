using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPT_store.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class Index : PageModel
    {
        public void OnGet()
        {
            
        }
    }
}