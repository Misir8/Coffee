using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coffe.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email sahəsi boş olmalı deyil")]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required(ErrorMessage = "Parol sahəsi boş olmalı deyil"), DisplayName("Parol")]
        [StringLength(100, ErrorMessage = "Parol minimum 7 simvoldan ibarət olmalıdır", MinimumLength = 7)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
 
        [DataType(DataType.Password), DisplayName("Parolu Təsdiq Et")]
        [Compare("Password", ErrorMessage = "Parollar üst-üstə düşmür")]
        public string ConfirmPassword { get; set; }
 
        public string Code { get; set; }
    }
}