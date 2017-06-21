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
    public class ProfessionalSummariesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfessionalSummariesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ProfessionalSummaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProfessionalSummary.ToListAsync());
        }

        // GET: ProfessionalSummaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalSummary = await _context.ProfessionalSummary
                .SingleOrDefaultAsync(m => m.Id == id);
            if (professionalSummary == null)
            {
                return NotFound();
            }

            return View(professionalSummary);
        }

        // GET: ProfessionalSummaries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProfessionalSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfessionalStatement")] ProfessionalSummary professionalSummary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professionalSummary);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(professionalSummary);
        }

        // GET: ProfessionalSummaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalSummary = await _context.ProfessionalSummary.SingleOrDefaultAsync(m => m.Id == id);
            if (professionalSummary == null)
            {
                return NotFound();
            }
            return View(professionalSummary);
        }

        // POST: ProfessionalSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfessionalStatement")] ProfessionalSummary professionalSummary)
        {
            if (id != professionalSummary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professionalSummary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionalSummaryExists(professionalSummary.Id))
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
            return View(professionalSummary);
        }

        // GET: ProfessionalSummaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalSummary = await _context.ProfessionalSummary
                .SingleOrDefaultAsync(m => m.Id == id);
            if (professionalSummary == null)
            {
                return NotFound();
            }

            return View(professionalSummary);
        }

        // POST: ProfessionalSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professionalSummary = await _context.ProfessionalSummary.SingleOrDefaultAsync(m => m.Id == id);
            _context.ProfessionalSummary.Remove(professionalSummary);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProfessionalSummaryExists(int id)
        {
            return _context.ProfessionalSummary.Any(e => e.Id == id);
        }
    }
}
