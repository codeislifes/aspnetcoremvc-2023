using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers
{
    // Home - HomeController
    // Product - ProductController
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
