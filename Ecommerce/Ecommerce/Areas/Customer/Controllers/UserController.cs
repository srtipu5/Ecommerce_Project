using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserController : Controller
    {
        UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public UserController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpPost]
        public JsonResult CheckUsernameAvailability(string userdata)
        {
            System.Threading.Thread.Sleep(200);

            var SearchData = _context.Users.SingleOrDefault(c => c.UserName == userdata);

            if (SearchData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }

        }
        public string ToTitleCase(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if(ModelState.IsValid)
            {
                var isExists = _context.Users.FirstOrDefault(c=>c.UserName.ToLower() == user.UserName.ToLower());
                if(isExists != null)
                {
                    TempData["exists"] = "Email Already Exists.";
                    return View();
                }

                user.AccountName = ToTitleCase(Regex.Replace(user.AccountName, " {2,}", " "));

                var createUser = await _userManager.CreateAsync(user, user.PasswordHash);
                if (createUser.Succeeded)
                {
                    var isSaveRole = await _userManager.AddToRoleAsync(user,"User");
                    TempData["save"] = "Account has been created.";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in createUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            var user = _context.Users.FirstOrDefault(c=>c.Id==id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(User user)
        {
            var userInfo = _context.Users.FirstOrDefault(c => c.Id == user.Id);

            if (userInfo == null)
            {
                return NotFound();
            }

            userInfo.AccountName = ToTitleCase(Regex.Replace(user.AccountName, " {2,}", " "));
            var updateUser = await _userManager.UpdateAsync(userInfo);
            if (updateUser.Succeeded)
            {
                TempData["update"] = "Account has been updated.";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            var user = _context.Users.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
      
            return View(user);

        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(User user)
        {
            var userInfo = _context.Users.FirstOrDefault(c => c.Id == user.Id);

            if (userInfo == null)
            {
                return NotFound();
            }

            var deleteUser = await _userManager.DeleteAsync(userInfo);
            if (deleteUser.Succeeded)
            {
                TempData["delete"] = "Account has been deleted.";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        public async Task<IActionResult> Details(string id)
        {
            var user = _context.Users.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
      
            return View(user);
        }
        [Authorize]
        public async Task<IActionResult> Lockout(string id)
        {
            var user = _context.Users.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Lockout(User user)
        {
            var userInfo = _context.Users.FirstOrDefault(c => c.Id == user.Id);

            if (userInfo == null)
            {
                return NotFound();
            }
            userInfo.LockoutEnd = DateTime.Now.AddYears(10);
            int rowCount = await _context.SaveChangesAsync();
            if (rowCount > 0)
            {
                TempData["lockout"] = "Account has been lockout.";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }
        [Authorize]
        public async Task<IActionResult> Active(string id)
        {
            var user = _context.Users.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Active(User user)
        {
            var userInfo = _context.Users.FirstOrDefault(c => c.Id == user.Id);

            if (userInfo == null)
            {
                return NotFound();
            }
            userInfo.LockoutEnd = DateTime.Now.AddDays(-1);
            int rowCount = await _context.SaveChangesAsync();
            if (rowCount > 0)
            {
                TempData["activate"] = "Account has been actived.";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

    }
}
