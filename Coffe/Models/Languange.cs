using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Languange
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public string LangName { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public string Read { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public string Write { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public string Understood { get; set; }
        public MainInfo MainInfo { get; set; }
        public int MainInfoId { get; set; }
    }
}