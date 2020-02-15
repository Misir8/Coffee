using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Computer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Komputer bilikləri seçin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Komputer bilikləri səviyyəsin seçin")]
        public string Degree { get; set; }
        public int MainInfoId { get; set; }
        public MainInfo MainInfo { get; set; }
    }
}