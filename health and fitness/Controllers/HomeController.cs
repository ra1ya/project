using Microsoft.AspNetCore.Mvc;

namespace health_and_fitness.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
