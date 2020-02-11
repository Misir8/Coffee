using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email sahəsi boş olmalı deyil")]
        [Display(Name = "Email")]
        public string Email { get; set; }
 
        [Required (ErrorMessage = "Parol sahəsi boş olmalı deyil")]
        [DataType(DataType.Password)]
        [Display(Name = "Parol")]
        public string Password { get; set; }
 
        [Display(Name = "Yadda saxla?")]
        public bool RememberMe { get; set; }
 
        public string ReturnUrl { get; set; }
    }
}