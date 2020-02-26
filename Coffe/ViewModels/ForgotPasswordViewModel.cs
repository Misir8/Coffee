using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "EmailReq")]
        [EmailAddress]
        public string Email { get; set; }
    }
}