using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ContactCRUDController : Controller
    {
        private readonly DataContext _context;

        public ContactCRUDController(DataContext context)
        {
            _context = context;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var contacts = await _context.Contacts.OrderByDescending(c => c.Id).ToListAsync();
            return View(contacts);
        }
        
        //Details 
        public async Task<IActionResult> Details(int ? id)
        {
            if (id != null)
            {
                var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
                if (contact != null)
                {
                    return View(contact);
                }
            }

            return NotFound();
        }
        
        //Delete 
        public async Task<IActionResult> Delete(int ? id)
        {
            if (id != null)
            {
                var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
                if (contact != null)
                {
                    return View(contact);
                }
            }

            return NotFound();
        }
        
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteContact(int ? id)
        {
            if (id != null)
            {
                var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
                if (contact != null)
                {
                    _context.Contacts.Remove(contact);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Kontakt mesajı uğurla silindi";
                    return RedirectToAction(nameof(Index));
                }
            }

            return NotFound();
        }
    }
}