using Microsoft.AspNetCore.Mvc;

namespace StrangeScout.Controllers
{
    public class ScoutingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Input()
        {
            return View();
        }
    }
}
