using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Extensions;
using Coffe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SliderController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment  _env;

        public SliderController(DataContext context, IWebHostEnvironment  env)
        {
            _context = context;
            _env = env;
        }
        
        // GET
        public IActionResult Index()
        {
            var sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        //CREATE
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            if (slider.Photo == null)
            {
                ModelState.AddModelError("Image", "Şəkil seçin");
                return View(slider);
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(slider);
            }
            if (!slider.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(slider);
            }
            slider.Image = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            TempData["success"] = "Slayder uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Sliders.Count() <= 1)
            {
                return RedirectToAction(nameof(Index));
            }
            if (id != null)
            {
                Slider slider = await _context.Sliders.FirstOrDefaultAsync(d => d.Id == id);
                return View(slider);
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id != null)
            {
                Slider slider = await _context.Sliders.FirstOrDefaultAsync(d => d.Id == id);
                if (slider != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "img", slider.Image);
                    _context.Sliders.Remove(slider);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Slayder uğurla silindi";
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
                Slider slider = await _context.Sliders.FirstOrDefaultAsync(d => d.Id == id);
                if (slider != null)
                {
                    return View(slider);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }

            var sliderDb = await _context.Sliders.FindAsync(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    var newPhoto = await slider.Photo.SaveFileAsync(_env.WebRootPath, "img");
                    IFormFileExtension.Delete(_env.WebRootPath, "img", sliderDb.Image);
                    sliderDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(slider);
                }
            }

            sliderDb.Title = slider.Title;
            sliderDb.Subtitle = slider.Subtitle;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Slayder uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Slider slider = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
                if (slider != null)
                    return View(slider);
            }
            return NotFound();
        }
    }
}