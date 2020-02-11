using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Coffe.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlıq boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər"), DisplayName("İkinci Başlıq")]
        public string Title { get; set; }
        [Required(ErrorMessage = "İkinci Başlıq boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər"), DisplayName("Başlıq")]
        public string Subtitle { get; set; }
        [StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər")]
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Şəkil")]
        public IFormFile Photo { get; set; }
    }
}