using Microsoft.AspNetCore.Mvc;

namespace CodeIsLife.Components;

public class NavBarViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult(View());
    }
}
