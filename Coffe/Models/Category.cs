using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Coffe.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kateqoriyanın adı boş ola bilməz"), StringLength(255, ErrorMessage = "Kateqoriyanın adı maksimum 255 simvoldan ibarət ola bilər"), DisplayName("Ad")]
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped, DisplayName("Şəkil")]
        public IFormFile Photo { get; set; }
        public List<Product> Products { get; set; }
        
    }
}