using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Əlaqə məlumatı boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər")]
        public string Info { get; set; }
    }
}