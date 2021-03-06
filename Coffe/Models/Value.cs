﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Value
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Dəyərlərimiz məlumatı boş ola bilməz"), DisplayName("Mətn")]
        public string Description { get; set; }
        [DisplayName("Mətn (ingliscə)")]
        public string DescriptionEn { get; set; }
        [DisplayName("Mətn (rusca)")]
        public string DescriptionRu { get; set; }
    }
}