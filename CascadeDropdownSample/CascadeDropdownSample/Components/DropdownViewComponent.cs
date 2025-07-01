using Microsoft.AspNetCore.Mvc;

namespace CascadeDropdownSample.Components
{
    public class DropdownViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string url)
        {
            ViewBag.Url = url;
            return View();
        }
    }
}
