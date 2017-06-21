using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeMB.Data;
using ResumeMB.Models;

namespace ResumeMB.Controllers
{
    public class QualificationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QualificationsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Qualifications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Qualifications.ToListAsync());
        }

        // GET: Qualifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualifications = await _context.Qualifications
                .SingleOrDefaultAsync(m => m.Id == id);
            if (qualifications == null)
            {
                return NotFound();
            }

            return View(qualifications);
        }

        // GET: Qualifications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Qualifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Skill")] Qualification qualification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qualification);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(qualification);
        }

        // GET: Qualifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualifications = await _context.Qualifications.SingleOrDefaultAsync(m => m.Id == id);
            if (qualifications == null)
            {
                return NotFound();
            }
            return View(qualifications);
        }

        // POST: Qualifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Skill")] Qualification qualification)
        {
            if (id != qualification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qualification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QualificationsExists(qualification.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(qualification);
        }

        // GET: Qualifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualifications = await _context.Qualifications
                .SingleOrDefaultAsync(m => m.Id == id);
            if (qualifications == null)
            {
                return NotFound();
            }

            return View(qualifications);
        }

        // POST: Qualifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qualifications = await _context.Qualifications.SingleOrDefaultAsync(m => m.Id == id);
            _context.Qualifications.Remove(qualifications);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool QualificationsExists(int id)
        {
            return _context.Qualifications.Any(e => e.Id == id);
        }
    }
}
