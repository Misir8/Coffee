using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            
            return View();
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Index(ContactViewModel cvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            Contact contact = new Contact
            {
                Firstname = cvm.Firstname,
                Email = cvm.Email,
                Number = cvm.Number,
                Message = cvm.Message
            };

            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            TempData["success"] = "Mesajınız uğurla göndərildi";
            return View();
        }

    }
}