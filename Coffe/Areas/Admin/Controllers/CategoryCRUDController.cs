using System;
using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Extensions;
using Coffe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryCRUDController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        public CategoryCRUDController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (category.Photo == null)
            {
                ModelState.AddModelError("Image", "Şəkil seçin");
                return View(category);
            }
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(category);
            }
            if (!category.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(category);
            }
            category.Image = await category.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            TempData["success"] = "Kateqoriya uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int ? id)
        {
            if (_context.Products.Count() <= 1)
            {
                return RedirectToAction(nameof(Index));
            }
            if (id != null)
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
                if (category != null)
                {
                    return View(category);
                }
            }

            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id != null)
            {
                Category category = await _context.Categories.FirstOrDefaultAsync(d => d.Id == id);
                if (category != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "img", category.Image);
                    _context.Categories.Remove(category);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Kateqoriya uğurla silindi";
                    return RedirectToAction(nameof(Index));
                }
            }
            return NotFound();
        }
        
        //EDIT
        
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Category category = await _context.Categories.FirstOrDefaultAsync(d => d.Id == id);
                if (category != null)
                {
                    return View(category);
                }
            }
            return NotFound();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            var categoryDb = await _context.Categories.FindAsync(category.Id);
            if (category.Photo != null)
            {
                try
                {
                    var newPhoto = await category.Photo.SaveFileAsync(_env.WebRootPath, "img");
                    IFormFileExtension.Delete(_env.WebRootPath, "img", categoryDb.Image);
                    categoryDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(category);
                }
            }

            categoryDb.Name = category.Name;
            categoryDb.NameEn = category.NameEn;
            categoryDb.NameRu = category.NameRu;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Kateqoriya uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (category != null)    
                    return View(category);
            }
            return NotFound();
        }

        
    }
}