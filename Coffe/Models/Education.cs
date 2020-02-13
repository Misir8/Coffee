using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Required]
        public string UniName { get; set; }
        [Required]
        public string EducationDate { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required]
        public string Degree { get; set; }
        public int MainInfoId { get; set; }
        public MainInfo MainInfo { get; set; }
    }
}