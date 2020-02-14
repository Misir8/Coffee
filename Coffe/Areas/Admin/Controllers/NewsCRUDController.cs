using System;
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
    public class NewsCRUDController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        public NewsCRUDController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var newses = await _context.Newses.ToListAsync(); 
            return View(newses);
        }
        //CREATE

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            if (news.Photo == null)
            {
                ModelState.AddModelError("Image", "Şəkil seçin");
                return View(news);
            }
            if (!news.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(news);
            }
            if (!news.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(news);
            }
            news.Image = await news.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Newses.AddAsync(news);
            await _context.SaveChangesAsync();
            TempData["success"] = "Xəbər uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                News news = await _context.Newses.FirstOrDefaultAsync(d => d.Id == id);
                return View(news);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteNews(int? id)
        {
            if (id != null)
            {
                News news = await _context.Newses.FirstOrDefaultAsync(d => d.Id == id);
                if (news != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "img", news.Image);
                    _context.Newses.Remove(news);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Xəbər uğurla silindi";
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
                News news = await _context.Newses.FirstOrDefaultAsync(d => d.Id == id);
                if (news != null)
                {
                    return View(news);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }

            var newsDb = await _context.Newses.FindAsync(news.Id);
            if (news.Photo != null)
            {
                try
                {
                    var newPhoto = await news.Photo.SaveFileAsync(_env.WebRootPath, "img");
                    IFormFileExtension.Delete(_env.WebRootPath, "img", newsDb.Image);
                    newsDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(news);
                }
            }

            newsDb.Title = news.Title;
            newsDb.Content = news.Content;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Xəbər uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                News news = await _context.Newses.FirstOrDefaultAsync(p => p.Id == id);
                if (news != null)    
                    return View(news);
            }
            return NotFound();
        }
        
    }
}