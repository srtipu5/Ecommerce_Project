using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _webHostEnvironment;

        public ProductsController(ApplicationDbContext context, IHostingEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductTypes).Include(p => p.SpecialTags);
            return View(await applicationDbContext.ToListAsync());
        }
        public void ProductSearch()
        {
            var searchBy = from SearchBy s in Enum.GetValues(typeof(SearchBy))
                           select new
                           {
                               ID = s.ToString(),
                               Name = s.ToString()
                           };
            ViewBag.SearchBy = new SelectList(searchBy, "ID", "Name");
        }

        public enum SearchBy
        {
            [Display(Name = "Product Namer")]
            Name,
            [Display(Name = "Product Price")]
            Price,
            [Display(Name = "Product Color")]
            Color,
            [Display(Name = "Product Type")]
            Type,
            [Display(Name = "Product Tag")]
            Tag,
            [Display(Name = "Product Available")]
            Available 
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ProductTypes)
                .Include(p => p.SpecialTags)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType");
            ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Image,ProductColor,IsAvailabe,ProductTypeId,SpecialTagId")] Products products,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var searchName = _context.Products.Where(x => x.Name.ToLower() == products.Name.ToLower()).FirstOrDefault();
                if (searchName != null)
                {
                    ViewBag.Message = "Product name already exist.";
                    ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType");
                    ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag"); 
                    return View(products);
                }
                if (image != null) 
                {
                    var name = Path.Combine(_webHostEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                if(image == null)
                {
                    products.Image = "Images/Noimage.jpg";
                }

                _context.Add(products);
                await _context.SaveChangesAsync();
                TempData["save"] = "Product has been added";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType", products.ProductTypeId);
            ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag", products.SpecialTagId);
            return View(products);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ProductTypes)
                .Include(p => p.SpecialTags)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (products == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType", products.ProductTypeId);
            ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag", products.SpecialTagId);
            return View(products);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Image,ProductColor,IsAvailabe,ProductTypeId,SpecialTagId")] Products products, IFormFile image)
        {
            if (id != products.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldName = _context.Products.Where(c => c.Id == id).Select(x => x.Name).FirstOrDefault();
                    var updateName = _context.Products.Where(x => x.Name.ToLower() == products.Name.ToLower()).Select(x => x.Name).FirstOrDefault();
                    
                    if (updateName != null && oldName != updateName)
                    {
                        products.Image = _context.Products.Where(c => c.Id == id).Select(x => x.Image).FirstOrDefault();
                        ViewBag.Message = "Product name already exist.";
                        ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType");
                        ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag");
                        return View(products);
                    }
                    if (image != null)
                    {
                        var name = Path.Combine(_webHostEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        products.Image = "Images/" + image.FileName;
                    }
                    if (image == null)
                    {
                        products.Image = _context.Products.Where(c=>c.Id == id).Select(x=>x.Image).FirstOrDefault();
                    }
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["update"] = "Product has been updated";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "ProductType", products.ProductTypeId);
            ViewData["SpecialTagId"] = new SelectList(_context.SpecialTags, "Id", "SpecialTag", products.SpecialTagId);
            return View(products);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ProductTypes)
                .Include(p => p.SpecialTags)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            TempData["delete"] = "Product has been deleted";
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
