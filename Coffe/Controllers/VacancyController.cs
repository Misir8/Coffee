using System.Linq;
using Coffe.DAL;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Coffe.Controllers
{
    public class VacancyController : Controller
    {
        public DataContext _context { get; set; }

        public VacancyController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {

            return View();
        }
        
        
    }
}