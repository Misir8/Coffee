using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email sahəsi boş olmalı deyil")]
        [EmailAddress]
        public string Email { get; set; }
    }
}