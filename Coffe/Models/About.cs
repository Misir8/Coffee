using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coffe.Models
{
    public class About
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        
        [Required(ErrorMessage = "Xana boş ola bilməz"), DisplayName("Mətn (Azərbaycan)")]

        public string Description { get; set; }
        [DisplayName("Mətn (İngilis)")]
        public string EnDescription { get; set; }
        [DisplayName("Mətn (Rus)")]
        public string RuDescription { get; set; }
    }
}