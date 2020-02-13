namespace Coffe.Models
{
    public class Languange
    {
        public int Id { get; set; }
        public string LangName { get; set; }
        public string Read { get; set; }
        public string Write { get; set; }
        public string Understood { get; set; }
        public MainInfo MainInfo { get; set; }
        public int MainInfoId { get; set; }
    }
}