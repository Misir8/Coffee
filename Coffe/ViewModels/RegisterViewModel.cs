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
        [Required(ErrorMessage = "Parol sahəsi mütləq doldurulmalıdır")]
        [DataType(DataType.Password)]
        [Display(Name = "Parol")]
        public string Password { get; set; }
 
        [Required(ErrorMessage = "Parolu təstiq et sahəsi mütləq doldurulmalıdır")]
        [Compare("Password", ErrorMessage = "Parollar üst-üstə düşmür")]
        [DataType(DataType.Password)]
        [Display(Name = "Parolu təsdiq et")]
        public string PasswordConfirm { get; set; }
    }
}