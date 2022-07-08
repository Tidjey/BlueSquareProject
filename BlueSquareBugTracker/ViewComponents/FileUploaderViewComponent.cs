using Microsoft.AspNetCore.Mvc;

namespace BlueSquareBugTracker.ViewComponents
{
    public class FileUploaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
