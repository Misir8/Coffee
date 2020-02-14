using System.Collections.Generic;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<News> Newses { get; set; }
        public News News { get; set; }
    }
}