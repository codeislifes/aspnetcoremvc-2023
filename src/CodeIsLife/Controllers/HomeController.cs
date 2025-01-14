using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers;

public class HomeController  : Controller
{
    public IActionResult Index()
    {
        //ViewData["name"] = "code is life";
        //ViewData["obj"] = new { name = "code is life", state = true };
        //ViewBag.name = "code is life";
        //ViewBag.obj = new { name = "code is life", state = true };

        return View();
    }

    public object Test()
    {
        return new { name = "code is life", state = true };
    }
}
