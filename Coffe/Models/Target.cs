using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Target
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Dəyərlərimiz məlumatı boş ola bilməz"), DisplayName("Mətn")]
        public string Description { get; set; }
    }
}