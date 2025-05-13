using CodeIsLife.Core;
using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Controllers;

public class ProductController : BaseController
{
    public IActionResult Index()
    {
        return GotoAction("List");
    }

    public IActionResult List()
    {
        SetTitle("Ürünler");
        return View();
    }
}
