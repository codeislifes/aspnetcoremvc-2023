using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers;

public class ProductController : Controller
{
    public IActionResult List()
    {
        return View();
    }
}
