using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HistoryController : Controller
    {
        private readonly DataContext _context;

        public HistoryController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var histories = _context.Histories.ToList();
            return View(histories);
        }
        
        //Edit
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                History history = await _context.Histories.FirstOrDefaultAsync(d => d.Id == id);
                if (history != null)
                {
                    return View(history);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(History history)
        {
            if (!ModelState.IsValid)
            {
                return View(history);
            }

            var historyDb = await _context.Histories.FindAsync(history.Id);
            

            historyDb.Description = history.Description;
            historyDb.DescriptionEn = history.DescriptionEn;
            historyDb.DescriptionRu = history.DescriptionRu;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Dəyərlərimiz məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}