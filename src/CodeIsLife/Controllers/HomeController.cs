using CodeIsLife.Core;
using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers;

public class HomeController : BaseController
{
    public IActionResult Index()
    {
        SetTitle("Günlük Özet");
        return View();
    }

    public object Test()
    {
        return new { name = "code is life", state = true };
    }
}
