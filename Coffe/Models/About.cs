using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Coffe.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlıq boş ola bilməz")]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}