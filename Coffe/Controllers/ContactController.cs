using System.Linq;
using Coffe.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Coffe.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var contact = _context.ContactInfos.ToList();
            return View(contact);
        }
    }
}