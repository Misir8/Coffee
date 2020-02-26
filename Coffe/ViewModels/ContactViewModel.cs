using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class ContactViewModel
    {
        public Contact Contact { get; set; }
        
        [Required(ErrorMessage = "FirstReq")]
        [StringLength(255, ErrorMessage = "Ad və soyad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad soyad")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "EmailReq")] 
        [StringLength(255, ErrorMessage = "EmailStringLength")]
        [EmailAddress(ErrorMessage = "EmailAddress")] 
        [DisplayName("E-poçt")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneReq")]
        [StringLength(255, ErrorMessage = "PhoneNumLength")]
        [DisplayName("Telefon")]
        public string Number { get; set; }
        [Required(ErrorMessage = "MesReq")]
        [DisplayName("Mesaj")]
        public string Message { get; set; }
    }
}