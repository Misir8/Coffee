using System;
using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Extensions;
using Coffe.Models;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductCRUDController : Controller
    {
        private readonly DataContext _context;

        private readonly IWebHostEnvironment _env;

        public ProductCRUDController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public async  Task<IActionResult> Index(int page = 1)
        {
            var query = _context.Products.AsNoTracking().OrderBy(p => p.Id);
            var model = await PagingList.CreateAsync(query, 7, page);
            return View(model);
        }
        
        //CREATE
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            if (product.Photo == null)
            {
                ModelState.AddModelError("Image", "Şəkil seçin");
                return View(product);
            }
            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(product);
            }
            if (!product.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(product);
            }
            product.Image = await product.Photo.SaveFileAsync(_env.WebRootPath, "img");
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            TempData["success"] = "Məhsul uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        //DELETE
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Products.Count() <= 1)
            {
                return RedirectToAction(nameof(Index));
            }
            if (id != null)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(d => d.Id == id);
                return View(product);
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id != null)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(d => d.Id == id);
                if (product != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "img", product.Image);
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Məhsul uğurla silindi";
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
                Product product = await _context.Products.FirstOrDefaultAsync(d => d.Id == id);
                if (product != null)
                {
                    ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
                    return View(product);
                }
            }
            return NotFound();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            var productDb = await _context.Products.FindAsync(product.Id);
            if (product.Photo != null)
            {
                try
                {
                    var newPhoto = await product.Photo.SaveFileAsync(_env.WebRootPath, "img");
                    IFormFileExtension.Delete(_env.WebRootPath, "img", productDb.Image);
                    productDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(product);
                }
            }

            productDb.Name = product.Name;
            productDb.Description = product.Description;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Məhsul uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)    
                    return View(product);
            }
            return NotFound();
        }
    }
}