using System;
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
        [DisplayName("Başlıq (ingliscə)")]
        [StringLength(255, ErrorMessage = "Başlığın uzunluğu 255 simvoldan çox ola bilməz")]
        public string TitleEn { get; set; }
        [DisplayName("Başlıq (rusca)")]
        [StringLength(255, ErrorMessage = "Başlığın uzunluğu 255 simvoldan çox ola bilməz")]
        public string TitleRu { get; set; }

        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn (ingliscə)")]
        public string ContentEn { get; set; }
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn (rusca)")]
        public string ContentRu { get; set; }
        public string Image { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}