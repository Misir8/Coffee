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
    [Area("admin")]
    public class AboutsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public AboutsController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var about = _context.Abouts.ToList();
            return View(about);
        }
        
        //EDIT
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                About about = await _context.Abouts.FirstOrDefaultAsync(d => d.Id == id);
                if (about != null)
                {
                    return View(about);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }

            var aboutDb = await _context.Abouts.FindAsync(about.Id);
            if (about.Photo != null)
            {
                try
                {
                    var newPhoto = await about.Photo.SaveFileAsync(_env.WebRootPath, "img");
                    IFormFileExtension.Delete(_env.WebRootPath, "img", aboutDb.Image);
                    aboutDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(about);
                }
            }
            aboutDb.Description = about.Description;
            aboutDb.EnDescription = about.EnDescription;
            aboutDb.RuDescription = about.RuDescription;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Biz kimik uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}