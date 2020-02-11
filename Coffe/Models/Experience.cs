
using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string WorkedDay { get; set; }
        [Required]
        public string WorkedMonth { get; set; }
        [Required]
        public string WorkedYear { get; set; }
        [Required]
        public string PositionAbout { get; set; }
        [Required]
        public string Salary { get; set; }

        public string LeftJob { get; set; }
        public string WorkNumber { get; set; }

        public MainInfo MainInfo { get; set; }
        public int MainInfoId { get; set; }
    }
}