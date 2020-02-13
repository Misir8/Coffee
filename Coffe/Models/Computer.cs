namespace Coffe.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public int MainInfoId { get; set; }
        public MainInfo MainInfo { get; set; }
    }
}