using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class RegisterViewModel
    {
        
        [Required(ErrorMessage = "Email sahəsi mütləq doldurulmalıdır")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PasswordReq")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
 
        [Required(ErrorMessage = "PasswordConfirmReq")]
        [Compare("Password", ErrorMessage = "Pass")]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordConfirm")]
        public string PasswordConfirm { get; set; }
    }
}