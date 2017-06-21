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
    public class AffiliationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AffiliationsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Affiliations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Affiliations.ToListAsync());
        }

        // GET: Affiliations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliations = await _context.Affiliations
                .SingleOrDefaultAsync(m => m.Id == id);
            if (affiliations == null)
            {
                return NotFound();
            }

            return View(affiliations);
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
        public async Task<IActionResult> Create([Bind("Id,AffilOrg,Role,Type,From,To,IsCurrent")] Affiliation affiliations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(affiliations);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(affiliations);
        }

        // GET: Affiliations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliations = await _context.Affiliations.SingleOrDefaultAsync(m => m.Id == id);
            if (affiliations == null)
            {
                return NotFound();
            }
            return View(affiliations);
        }

        // POST: Affiliations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AffilOrg,Role,Type,From,To,IsCurrent")] Affiliation affiliations)
        {
            if (id != affiliations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliationsExists(affiliations.Id))
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
            return View(affiliations);
        }

        // GET: Affiliations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliations = await _context.Affiliations
                .SingleOrDefaultAsync(m => m.Id == id);
            if (affiliations == null)
            {
                return NotFound();
            }

            return View(affiliations);
        }

        // POST: Affiliations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliations = await _context.Affiliations.SingleOrDefaultAsync(m => m.Id == id);
            _context.Affiliations.Remove(affiliations);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AffiliationsExists(int id)
        {
            return _context.Affiliations.Any(e => e.Id == id);
        }
    }
}
