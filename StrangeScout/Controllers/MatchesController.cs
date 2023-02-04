using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StrangeScout.Data;
using StrangeScout.Models;

namespace StrangeScout.Controllers
{
    public class MatchesController : Controller
    {
        private readonly StrangeScoutContext _context;

        public MatchesController(StrangeScoutContext context)
        {
            _context = context;
        }

        // GET: Match
        public async Task<IActionResult> Index()
        {
              return _context.Matches != null ? 
                          View(await _context.Matches.ToListAsync()) :
                          Problem("Entity set 'StrangeScoutContext.Matches'  is null.");
        }

        // GET: Match/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Matches == null)
            {
                return NotFound();
            }

            var matches = await _context.Matches
                .FirstOrDefaultAsync(m => m.ID == id);
            if (matches == null)
            {
                return NotFound();
            }

            return View(matches);
        }

        // GET: Match/Create

        // POST: Match/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // GET: Match/Edit/5
        public async Task<IActionResult> Edit(int? ID)
        {
            if (ID == null || _context.Matches == null)
            {
                return NotFound();
            }

            var matches = await _context.Matches.FindAsync(ID);
            if (matches == null)
            {
                return NotFound();
            }
            return View(matches);
        }

        // POST: Match/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int ID, [Bind("ID,Event,Round,TeamNumber,Cones,Cubes,DoubleSubstation,SingleSubstation,Center,Top,Mid,Bot,CycleTime,Engaged,Points")] Matches matches)
        {
            if (ID != matches.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matches);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchesExists(matches.ID))
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
            return View(matches);
        }

        // GET: Match/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Matches == null)
            {
                return NotFound();
            }

            var matches = await _context.Matches
                .FirstOrDefaultAsync(m => m.ID == id);
            if (matches == null)
            {
                return NotFound();
            }

            return View(matches);
        }

        // POST: Match/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Matches == null)
            {
                return Problem("Entity set 'StrangeScoutContext.Matches'  is null.");
            }
            var matches = await _context.Matches.FindAsync(id);
            if (matches != null)
            {
                _context.Matches.Remove(matches);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchesExists(int id)
        {
          return (_context.Matches?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
