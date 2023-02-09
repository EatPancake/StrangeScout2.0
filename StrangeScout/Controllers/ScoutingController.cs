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
        public async Task<IActionResult> Index([Bind("ID,Round,Event,TeamNumber,Cones,Cones_A,Cubes,Cubes_A,DoubleSubstation,DoubleSubstation_A,SingleSubstation,SingleSubstation_A,Center,Center_A,CycleTime,Top,Top_A,Mid,Mid_A,Bot,Bot_A,Engaged")] Matches matches)
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
