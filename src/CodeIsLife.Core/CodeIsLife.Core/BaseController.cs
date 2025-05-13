
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CodeIsLife.Core;
public abstract class BaseController : Controller
{
    public void SetTitle(string title)
    {
        var value = $"{title} | code is life";
        ViewBag.Title = value;
    }

    public RedirectToActionResult GotoAction(string actionName)
    {
        return RedirectToAction(actionName);
    }
}
