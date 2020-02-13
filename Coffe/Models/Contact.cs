using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad və soyad xanası boş ola biməz")]
        [StringLength(255, ErrorMessage = "Ad və soyad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad soyad")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Email xanası boş ola bilməz")] 
        [StringLength(255, ErrorMessage = "Email xanasında maksimum 255 simvol ola bilər")]
        [EmailAddress(ErrorMessage = "Email ünvanı düzgün yazın")] 
        [DisplayName("E-poçt")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon xanası boş ola bilməz")]
        [StringLength(255, ErrorMessage = "Telefon xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Telefon")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Mesaj xanası boş ola bilməz")]
        [DisplayName("Mesaj")]
        public string Message { get; set; }
    }
}