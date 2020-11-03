using System.ComponentModel.DataAnnotations;

namespace FPT_store.Models
{
    public class RegisterModel
    {
        [Required] public string Email { get; set; }
        [StringLength(100, MinimumLength = 6)] public string Name { get; set; }
        [StringLength(100, MinimumLength = 6)] public string Password { get; set; }
        [Compare("Password")] public string ConfirmsPassword { get; set; }

        [Required] public string Phone { get; set; }
        [Required] public string Address { get; set; }
    }
}