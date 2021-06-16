using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //GET Checkout Method
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        //POST Checkout Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Checkout(Order anOrder)
        {
            List<Products> addProducts = new List<Products>();

            addProducts = HttpContext.Session.Get<List<Products>>("Add Products");
            if(addProducts != null)
            {
                foreach (var product in addProducts)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }

            anOrder.OrderNo = GetOrderNo();
            _context.Orders.Add(anOrder);
            await _context.SaveChangesAsync();
            HttpContext.Session.Set("Add Products",null);

            return View();
        }

        public string GetOrderNo()
        {
            int rowCount = _context.Orders.Count() + 1;
            return rowCount.ToString("000");
        }
    }
}
