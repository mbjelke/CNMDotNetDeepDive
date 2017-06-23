using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class AffiliationsController : Controller
    {
        private readonly ResumeProjectContext _context;

        public AffiliationsController(ResumeProjectContext context)
        {
            _context = context;    
        }

        // GET: Affiliations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Affiliation.ToListAsync());
        }

        // GET: Affiliations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliation = await _context.Affiliation
                .SingleOrDefaultAsync(m => m.Id == id);
            if (affiliation == null)
            {
                return NotFound();
            }

            return View(affiliation);
        }

        // GET: Affiliations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affiliations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AffilOrg,Role,Type,From,To,IsCurrent")] Affiliation affiliation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(affiliation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(affiliation);
        }

        // GET: Affiliations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliation = await _context.Affiliation.SingleOrDefaultAsync(m => m.Id == id);
            if (affiliation == null)
            {
                return NotFound();
            }
            return View(affiliation);
        }

        // POST: Affiliations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AffilOrg,Role,Type,From,To,IsCurrent")] Affiliation affiliation)
        {
            if (id != affiliation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliationExists(affiliation.Id))
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
            return View(affiliation);
        }

        // GET: Affiliations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliation = await _context.Affiliation
                .SingleOrDefaultAsync(m => m.Id == id);
            if (affiliation == null)
            {
                return NotFound();
            }

            return View(affiliation);
        }

        // POST: Affiliations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliation = await _context.Affiliation.SingleOrDefaultAsync(m => m.Id == id);
            _context.Affiliation.Remove(affiliation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AffiliationExists(int id)
        {
            return _context.Affiliation.Any(e => e.Id == id);
        }
    }
}
