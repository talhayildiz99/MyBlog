using Microsoft.AspNetCore.Mvc;

namespace MyBlog_PresentationLayer.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
