using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList.Mvc.Core;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductTypes).Include(p => p.SpecialTags).ToList().ToPagedList(pageNumber: page ?? 1,pageSize: 3);
            return View(applicationDbContext);
        }
        //Post method for searching
        [HttpPost]
        public IActionResult Index(int? page,string searchBy)
        {
          
            if (searchBy != null)
            {
                var searchItem = _context.Products.Include(p => p.ProductTypes).Include(p => p.SpecialTags).Where(x => x.Name.StartsWith(searchBy) || x.ProductColor.StartsWith(searchBy) ||
                x.ProductTypes.ProductType.StartsWith(searchBy) || x.SpecialTags.SpecialTag.StartsWith(searchBy)).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 3);
                return View(searchItem);
            }
            
            var applicationDbContext = _context.Products.Include(p => p.ProductTypes).Include(p => p.SpecialTags).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 3);
            return View(applicationDbContext);
        }

        //Details GET Method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductTypes)
                .Include(p => p.SpecialTags)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        // Add Product to cart
        [Authorize]
        public IActionResult AddToCart(int? id)
        {
            var product =  _context.Products
                  .Include(p => p.ProductTypes)
                  .Include(p => p.SpecialTags)
                  .FirstOrDefault(m => m.Id == id);

            AddToCartProduct(product);
            return RedirectToAction("Index");
        }


        //Details POST Method
        [HttpPost]
        [ActionName("Details")]
        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductTypes)
                .Include(p => p.SpecialTags)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            AddToCartProduct(product);

            return View(product);
        }

        public void AddToCartProduct(Products product)
        {
            List<Products> addProducts = new List<Products>();

            addProducts = HttpContext.Session.Get<List<Products>>("Add Products");

            if (addProducts == null)
            {
                addProducts = new List<Products>();
            }

            addProducts.Add(product);
            HttpContext.Session.Set("Add Products", addProducts);
        }

        //GET Product Cart Remove Action Method
        [Authorize]
        public IActionResult Remove(int? id)
        {
            List<Products> addProducts = HttpContext.Session.Get<List<Products>>("Add Products");
            if (addProducts != null)
            {
                var removeProduct = addProducts.FirstOrDefault(c=>c.Id==id);
                if(removeProduct != null)
                {
                    addProducts.Remove(removeProduct);
                    HttpContext.Session.Set("Add Products", addProducts);
                }
            }
            //here action_name = cart 
            return RedirectToAction("Cart");
        }

        //GET Product Cart Action Method
        [Authorize]
        public IActionResult Cart()
        {
           List<Products> addProducts = HttpContext.Session.Get<List<Products>>("Add Products");
            if (addProducts == null)
            {
                addProducts = new List<Products>();
            }
            return View(addProducts);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
