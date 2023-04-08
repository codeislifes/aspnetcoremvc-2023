using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
