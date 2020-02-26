using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "EmailReq")]
        [Display(Name = "Email")]
        public string Email { get; set; }
 
        [Required (ErrorMessage = "PassReq")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
 
        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
 
        public string ReturnUrl { get; set; }
    }
}