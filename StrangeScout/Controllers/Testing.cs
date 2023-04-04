using Microsoft.AspNetCore.Mvc;

namespace StrangeScout.Controllers
{
    public class Testing : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}