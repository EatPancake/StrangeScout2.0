using Microsoft.AspNetCore.Mvc;
using StrangeScout.Data;
using StrangeScout.Models;
using Microsoft.EntityFrameworkCore;

namespace StrangeScout.Controllers
{
    public class ScoutingController : Controller
    {
        private readonly StrangeScoutContext _context;

        public ScoutingController(StrangeScoutContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("ID,Round,Event,TeamNumber,TeamName,Cones,Cubes,DoubleSubstation,SingleSubstation,Center,Top,Mid,Bot")] Matches matches)
        {
            if(ModelState.IsValid)
            {
                _context.Add(matches);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matches);
        }
    }

}
