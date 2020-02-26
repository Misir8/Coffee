using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ValueController : Controller
    {
        private readonly DataContext _context;

        public ValueController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var values = _context.Values.ToList();
            return View(values);
        }
        
        //Edit
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Value value = await _context.Values.FirstOrDefaultAsync(d => d.Id == id);
                if (value != null)
                {
                    return View(value);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Value value)
        {
            if (!ModelState.IsValid)
            {
                return View(value);
            }

            var valuetDb = await _context.Values.FindAsync(value.Id);
            

            valuetDb.Description = value.Description;
            valuetDb.DescriptionEn = value.DescriptionEn;
            valuetDb.DescriptionRu = value.DescriptionRu;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Dəyərlərimiz məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}