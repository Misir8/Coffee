using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Coffe.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlıq xanası boş ola bilməz")]
        [DisplayName("Başlıq")]
        [StringLength(255, ErrorMessage = "Başlığın uzunluğu 255 simvoldan çox ola bilməz")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn")]
        public string Content { get; set; }

        public string Image { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}