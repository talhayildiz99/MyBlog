using Microsoft.AspNetCore.Mvc;

namespace MyBlog_PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
