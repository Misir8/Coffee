using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coffe.Models
{
    
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Məhsulun adı boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər"), DisplayName("Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Məhsulun adı boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər"), DisplayName("Ad (ingliscə)")]
        public string NameEn { get; set; }
        [Required(ErrorMessage = "Məhsulun adı boş ola bilməz"), StringLength(255, ErrorMessage = "Simvolların uzunglu maksimum 255 ola bilər"), DisplayName("Ad (rusca)")]
        public string NameRu { get; set; }
        [Required(ErrorMessage = "Məhsulun mətni boş ola bilməz"), DisplayName("Mətn")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Məhsulun mətni boş ola bilməz"), DisplayName("Mətn (ingliscə)")]
        public string DescriptionEn { get; set; }
        [Required(ErrorMessage = "Məhsulun mətni boş ola bilməz"), DisplayName("Mətn (rusca)")]
        public string DescriptionRu { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [DisplayName("Kateqoriya")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [NotMapped,  DisplayName("Şəkil")]
        public IFormFile Photo { get; set; }
    }

    
}