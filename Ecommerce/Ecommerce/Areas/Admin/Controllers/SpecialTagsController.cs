using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SpecialTagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpecialTagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SpecialTags
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpecialTags.ToListAsync());
        }

        // GET: Admin/SpecialTags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTags = await _context.SpecialTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialTags == null)
            {
                return NotFound();
            }

            return View(specialTags);
        }

        // GET: Admin/SpecialTags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SpecialTags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpecialTag")] SpecialTags specialTags)
        {
            var specialTag =await _context.SpecialTags.FirstOrDefaultAsync(c=>c.SpecialTag.ToLower() == specialTags.SpecialTag.ToLower());
            if (specialTag != null)
            {
                TempData["Msg"] = "Already Exists.";
                return View();
            }
            if (ModelState.IsValid)
            {
                _context.Add(specialTags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }

        // GET: Admin/SpecialTags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTags = await _context.SpecialTags.FindAsync(id);
            if (specialTags == null)
            {
                return NotFound();
            }
            return View(specialTags);
        }

        // POST: Admin/SpecialTags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SpecialTag")] SpecialTags specialTags)
        {
            if (id != specialTags.Id)
            {
                return NotFound();
            }
            var specialTag = await _context.SpecialTags.FirstOrDefaultAsync(c => c.SpecialTag.ToLower() == specialTags.SpecialTag.ToLower());
            if (specialTag != null)
            {
                TempData["Msg"] = "Already Exists.";
                return View();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialTags);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialTagsExists(specialTags.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }

        // GET: Admin/SpecialTags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTags = await _context.SpecialTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialTags == null)
            {
                return NotFound();
            }

            return View(specialTags);
        }

        // POST: Admin/SpecialTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialTags = await _context.SpecialTags.FindAsync(id);
            _context.SpecialTags.Remove(specialTags);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialTagsExists(int id)
        {
            return _context.SpecialTags.Any(e => e.Id == id);
        }
    }
}
