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
    public class AccomplishmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccomplishmentsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Accomplishments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Accomplishments.Include(a => a.Job);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accomplishments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishments
                .Include(a => a.Job)
                .SingleOrDefaultAsync(m => m.AccomplishmentId == id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // GET: Accomplishments/Create
        public IActionResult Create()
        {
            ViewData["JobID"] = new SelectList(_context.Experience, "JobID", "Company");
            return View();
        }

        // POST: Accomplishments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccomplishmentId,JobID,Accomp")] Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["JobID"] = new SelectList(_context.Experience, "JobID", "Company", accomplishment.JobID);
            return View(accomplishment);
        }

        // GET: Accomplishments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishments.SingleOrDefaultAsync(m => m.AccomplishmentId == id);
            if (accomplishment == null)
            {
                return NotFound();
            }
            ViewData["JobID"] = new SelectList(_context.Experience, "JobID", "Company", accomplishment.JobID);
            return View(accomplishment);
        }

        // POST: Accomplishments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccomplishmentId,JobID,Accomp")] Accomplishment accomplishment)
        {
            if (id != accomplishment.AccomplishmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accomplishment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccomplishmentExists(accomplishment.AccomplishmentId))
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
            ViewData["JobID"] = new SelectList(_context.Experience, "JobID", "Company", accomplishment.JobID);
            return View(accomplishment);
        }

        // GET: Accomplishments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishments
                .Include(a => a.Job)
                .SingleOrDefaultAsync(m => m.AccomplishmentId == id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // POST: Accomplishments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accomplishment = await _context.Accomplishments.SingleOrDefaultAsync(m => m.AccomplishmentId == id);
            _context.Accomplishments.Remove(accomplishment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AccomplishmentExists(int id)
        {
            return _context.Accomplishments.Any(e => e.AccomplishmentId == id);
        }
    }
}
