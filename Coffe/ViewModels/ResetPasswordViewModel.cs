using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "EmailReq")]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required(ErrorMessage = "PassReq"), DisplayName("Password")]
        [StringLength(100, ErrorMessage = "PasswordLength", MinimumLength = 7)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
 
        [DataType(DataType.Password), DisplayName("PassConfirm")]
        [Compare("Password", ErrorMessage = "Pass")]
        public string ConfirmPassword { get; set; }
 
        public string Code { get; set; }
    }
}